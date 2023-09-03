using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Utility;

public unsafe class UnmanagedJaggedArray<TItem> : IDisposable, IEnumerable<UnmanagedSegment<TItem>>
    where TItem : unmanaged
{
    protected TItem** _pointers;
    protected int* _lengths;
    protected int _currentLength;
    protected int _capacity;

    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _currentLength;
    }

    public Span<TItem> this[int i]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            CheckDisposed();
            CheckRange(i);

            return new(_pointers[i], _lengths[i]);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedJaggedArray(int initialCapacity = 4)
    {
        if (initialCapacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialCapacity));
        }

        _capacity = initialCapacity;

        _pointers = (TItem**) Marshal.AllocHGlobal(_capacity * sizeof(TItem*));
        _lengths = (int*) Marshal.AllocHGlobal(_capacity * sizeof(int));

        for (int i = 0; i < _capacity; i++)
        {
            _pointers[i] = null;
            _lengths[i] = 0;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add<TUnmanaged>(in TUnmanaged item)
        where TUnmanaged : IUnmanaged<TItem>
    {
        CheckDisposed();
        EnsureCapacity();

        _lengths[_currentLength] =  item.Length;

        item.TransferOwnership(ref _pointers[_currentLength]);

        _currentLength++;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add(TItem* pointer, int length)
    {
        Add(new ReadOnlySpan<TItem>(pointer, length));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add(ReadOnlySpan<TItem> item)
    {
        CheckDisposed();
        EnsureCapacity();

        _lengths[_currentLength] = item.Length;
        _pointers[_currentLength] = (TItem*)Marshal.AllocHGlobal(item.Length * sizeof(TItem));

        item.CopyTo(this[_currentLength++]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TItem** AsPointer()
    {
        CheckDisposed();

        return _pointers;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Enumerator GetEnumerator()
    {
        CheckDisposed();

        return new Enumerator(_pointers, _lengths, _currentLength);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        CheckDisposed();

        return new Enumerator(_pointers, _lengths, _currentLength);
    }

    IEnumerator<UnmanagedSegment<TItem>> IEnumerable<UnmanagedSegment<TItem>>.GetEnumerator()
    {
        CheckDisposed();

        return new Enumerator(_pointers, _lengths, _currentLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose()
    {
        if (_pointers == (TItem**) nint.Zero)
        {
            return;
        }

        for (int i = 0; i < _currentLength; i++)
        {
            if (_pointers[i] == (TItem*)nint.Zero)
            {
                continue;
            }
            
            Marshal.FreeHGlobal((IntPtr)_pointers[i]);
            _pointers[i] = null;
            _lengths[i] = 0;
        }

        Marshal.FreeHGlobal((IntPtr)_pointers);
        _pointers = null;

        Marshal.FreeHGlobal((IntPtr)_lengths);
        _lengths = null;

        GC.SuppressFinalize(this);
    }

    ~UnmanagedJaggedArray()
    {
        Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void EnsureCapacity()
    {
        if (_currentLength < _capacity) return;

        // Double the capacity.
        int newCapacity = _capacity * 2;

        TItem** newPointers = (TItem**)Marshal.AllocHGlobal(newCapacity * sizeof(TItem*));
        int* newLengths = (int*)Marshal.AllocHGlobal(newCapacity * sizeof(int));

        for (int i = 0; i < _currentLength; i++)
        {
            newPointers[i] = _pointers[i];
            newLengths[i] = _lengths[i];
        }

        for (int i = _currentLength; i < newCapacity; i++)
        {
            newPointers[i] = null;
            newLengths[i] = 0;
        }

        Marshal.FreeHGlobal((IntPtr)_pointers);
        Marshal.FreeHGlobal((IntPtr)_lengths);

        _pointers = newPointers;
        _lengths = newLengths;
        _capacity = newCapacity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected UnmanagedSegment<TItem> CreateSegment(int i)
    {
        return new UnmanagedSegment<TItem>(_pointers[i], _lengths[i]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void CheckDisposed()
    {
        if (_pointers == (TItem**)nint.Zero || _lengths == (TItem**)nint.Zero)
        {
            throw new ObjectDisposedException(nameof(UnmanagedJaggedArray<TItem>));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void CheckRange(int index)
    {
        if (index < 0 || index >= _currentLength)
        {
            throw new IndexOutOfRangeException(nameof(index));
        }
    }

    public struct Enumerator : IEnumerator<UnmanagedSegment<TItem>>
    {
        private readonly TItem** _pointers;
        private readonly int* _lengths;
        private readonly int _currentLength;
        private int _currentIndex;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Enumerator(TItem** pointers, int* lengths, int currentLength)
        {
            _pointers = pointers;
            _lengths = lengths;
            _currentLength = currentLength;
            _currentIndex = -1;
        }

        public UnmanagedSegment<TItem> Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (_currentIndex < 0 || _currentIndex >= _currentLength)
                {
                    throw new InvalidOperationException("Index does not match size of the array.");
                }

                return new UnmanagedSegment<TItem>(_pointers[_currentIndex], _lengths[_currentIndex]);
            }
        }

        object IEnumerator.Current => Current;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++_currentIndex < _currentLength;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public void Dispose() { }
    }
}