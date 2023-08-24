using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe sealed class UnmanagedBuffer<TItem> : IEnumerable<TItem>, IUnmanaged<TItem>
    where TItem : unmanaged
{
    private TItem* _pointer;
    private readonly int _length;

    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _length;
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedBuffer(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(size));
        }

        _pointer = (TItem*) Marshal.AllocHGlobal(size * sizeof(TItem));
        _length = size;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<TItem> AsSpan()
    {
        CheckDisposed();

        return new(_pointer, _length);
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

        _pointer = (TItem*) nint.Zero;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose()
    {
        if ((nint)_pointer != nint.Zero)
        {
            Marshal.FreeHGlobal((nint)_pointer);
        }

        GC.SuppressFinalize(this);
    }

    ~UnmanagedBuffer()
    {
        Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedBufferEnumerator<TItem> GetEnumerator()
    {
        CheckDisposed();

        return new UnmanagedBufferEnumerator<TItem>(_pointer, _length);
    }

    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
    {
        CheckDisposed();

        return new UnmanagedBufferEnumerator<TItem>(_pointer, _length);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        CheckDisposed();

        return new UnmanagedBufferEnumerator<TItem>(_pointer, _length);
    }

    public override string ToString()
    {
        return AsSpan().ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void CheckDisposed()
    {
        if ((nint)_pointer == nint.Zero)
        {
            throw new ObjectDisposedException(nameof(UnmanagedBuffer<TItem>));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void CheckRange(int i)
    {
        if (i < 0 || i >= _length)
        {
            throw new IndexOutOfRangeException(nameof(i));
        }
    }

    public struct UnmanagedBufferEnumerator<TItem> : IEnumerator<TItem> where TItem : unmanaged
    {
        private readonly TItem* _pointer;
        private readonly int _length;
        private int _currentIndex;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UnmanagedBufferEnumerator(TItem* pointer, int length)
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
}
