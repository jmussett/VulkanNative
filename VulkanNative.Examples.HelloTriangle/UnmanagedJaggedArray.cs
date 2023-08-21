using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace VulkanNative.Examples.HelloTriangle;

// TODO: make unsealed
public unsafe sealed class UnmanagedJaggedArray<TItem> : IDisposable, IEnumerable<UnmanagedSegment<TItem>>
    where TItem : unmanaged
{
    private TItem** _pointers;
    private int* _lengths;
    private int _currentLength;
    private readonly int _maxLength;

    public int Length => _currentLength;
    public int MaxLength => _maxLength;

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
    public UnmanagedJaggedArray(int maxLength)
    {
        if (maxLength <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(maxLength));
        }

        _maxLength = maxLength;

        _pointers = (TItem**) Marshal.AllocHGlobal(maxLength * sizeof(TItem*));
        _lengths = (int*) Marshal.AllocHGlobal(maxLength * sizeof(int));

        for (int i = 0; i < maxLength; i++)
        {
            _pointers[i] = null;
            _lengths[i] = 0;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add<TUnmanaged>(in TUnmanaged item)
        where TUnmanaged : unmanaged, IUnmanaged<TItem>
    {
        CheckDisposed();

        if (_currentLength >= _maxLength)
        {
            throw new InvalidOperationException("The jagged array is at its max length.");
        }

        _lengths[_currentLength] =  item.Length;

        item.TransferOwnership(ref _pointers[_currentLength]);

        _currentLength++;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add(ReadOnlySpan<TItem> item)
    {
        CheckDisposed();

        if (_currentLength >= _maxLength)
        {
            throw new InvalidOperationException("The jagged array is at its max length.");
        }

        _lengths[_currentLength] = item.Length;
        _pointers[_currentLength] = (TItem*)Marshal.AllocHGlobal(item.Length * sizeof(TItem));

        item.CopyTo(this[_currentLength]);

        _currentLength++;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TItem** AsPointer()
    {
        CheckDisposed();

        return _pointers;
    }

    public IEnumerator<UnmanagedSegment<TItem>> GetEnumerator()
    {
        CheckDisposed();

        for (int i = 0; i < _currentLength; i++)
        {
            yield return CreateSegment(i);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
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
    private UnmanagedSegment<TItem> CreateSegment(int i)
    {
        return new UnmanagedSegment<TItem>(_pointers[i], _lengths[i]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void CheckDisposed()
    {
        if (_pointers == (TItem**)nint.Zero || _lengths == (TItem**)nint.Zero)
        {
            throw new ObjectDisposedException(nameof(UnmanagedJaggedArray<TItem>));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void CheckRange(int index)
    {
        if (index < 0 || index >= _currentLength)
        {
            throw new IndexOutOfRangeException(nameof(index));
        }
    }
}