using Microsoft.Extensions.ObjectPool;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Utility;

public unsafe class UnmanagedBuffer<TItem> : IEnumerable<TItem>, IUnmanaged<TItem>
    where TItem : unmanaged
{
    private static DefaultObjectPool<UnmanagedBuffer<TItem>> _pool
        = new(new UnmanageBufferObjectPolicy());

    private bool _fixedLength;

    private TItem* _pointer;
    private int _currentLength;
    private int _capacity;
    
    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _currentLength;
    }

    public TItem this[int i]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            CheckDisposed();
            CheckRange(i);

            return _pointer[i];
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            CheckDisposed();
            CheckRange(i);

            _pointer[i] = value;
        }
    }

    public UnmanagedSegment<TItem> this[Range range]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            int start = range.Start.IsFromEnd ? Length - range.Start.Value : range.Start.Value;
            int end = range.End.IsFromEnd ? Length - range.End.Value : range.End.Value;

            return Slice(start, end - start);
        }
    }

    protected UnmanagedBuffer() {}

    public static UnmanagedBuffer<TItem> Create(int initialCapacity = 4, bool fixedLength = false)
    {
        var buffer = _pool.Get();
        
        buffer.Initialize(initialCapacity, fixedLength);

        return buffer;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void Initialize(int initialCapacity = 4, bool fixedLength = false)
    {
        if ((nint)_pointer != nint.Zero)
        {
            throw new InvalidOperationException("Object has not been disposed.");
        }

        if (initialCapacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialCapacity));
        }

        _capacity = initialCapacity;

        _pointer = (TItem*)Marshal.AllocHGlobal(_capacity * sizeof(TItem));
        _fixedLength = fixedLength;

        _currentLength = _fixedLength ? initialCapacity : 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add(in TItem item)
    {
        CheckDisposed();
        
        if (_fixedLength)
        {
            throw new NotSupportedException("Unable to extend a fixed length buffer.");
        }
        
        EnsureCapacity();

        _pointer[_currentLength] = item;

        _currentLength++;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<TItem> AsSpan()
    {
        CheckDisposed();

        return new(_pointer, _currentLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TItem* AsPointer()
    {
        CheckDisposed();

        return _pointer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void TransferOwnership(ref TItem* destination)
    {
        CheckDisposed();

        destination = _pointer;

        _pointer = null;

        _pool.Return(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedSegment<TItem> Slice(int start, int length)
    {
        if (start < 0 || length < 0 || start + length > _currentLength)
        {
            throw new ArgumentOutOfRangeException();
        }

        return new UnmanagedSegment<TItem>(_pointer + start, length);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        _pool.Return(this);
    }

    protected void Reset()
    {
        if ((nint)_pointer != nint.Zero)
        {
            Marshal.FreeHGlobal((nint)_pointer);
        }

        _pointer = null;
    }

    ~UnmanagedBuffer()
    {
        Dispose(false);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Enumerator GetEnumerator()
    {
        CheckDisposed();

        return new Enumerator(_pointer, _currentLength);
    }

    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
    {
        CheckDisposed();

        return new Enumerator(_pointer, _currentLength);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        CheckDisposed();

        return new Enumerator(_pointer, _currentLength);
    }

    public static implicit operator Span<TItem>(UnmanagedBuffer<TItem> buffer) => buffer.AsSpan();

    public override string ToString()
    {
        return AsSpan().ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void EnsureCapacity()
    {
        if (_currentLength < _capacity) return;

        // Double the capacity.
        int newCapacity = _capacity * 2;

        _pointer = (TItem*) Marshal.ReAllocHGlobal((nint)_pointer, newCapacity * sizeof(TItem));
        _capacity = newCapacity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void CheckDisposed()
    {
        if ((nint)_pointer == nint.Zero)
        {
            throw new ObjectDisposedException(nameof(UnmanagedBuffer<TItem>));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void CheckRange(int i)
    {
        if (i < 0 || i >= _currentLength)
        {
            throw new IndexOutOfRangeException(nameof(i));
        }
    }

    public struct Enumerator : IEnumerator<TItem>
    {
        private readonly TItem* _pointer;
        private readonly int _length;
        private int _currentIndex;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Enumerator(TItem* pointer, int length)
        {
            _pointer = pointer;
            _length = length;
            _currentIndex = -1;
        }

        public TItem Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (_currentIndex < 0 || _currentIndex >= _length)
                {
                    throw new InvalidOperationException("Index does not match size of the array.");
                }
                return _pointer[_currentIndex];
            }
        }

        object IEnumerator.Current => Current;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++_currentIndex < _length;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public void Dispose() { }
    }

    private class UnmanageBufferObjectPolicy : IPooledObjectPolicy<UnmanagedBuffer<TItem>>
    {
        public UnmanagedBuffer<TItem> Create() => new();
        public bool Return(UnmanagedBuffer<TItem> buffer)
        {
            // Make sure the buffer is reset before returning
            buffer.Reset();

            return true;
        }
    }
}
