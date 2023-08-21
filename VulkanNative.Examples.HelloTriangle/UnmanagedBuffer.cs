using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe struct UnmanagedBuffer<T> : IEnumerable<T>, IUnmanaged<T>
    where T : unmanaged
{
    private T* _pointer;

    public readonly int Length { get; }

    public T this[int i]
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

        Length = size;
        _pointer = (T*) Marshal.AllocHGlobal(size * sizeof(T));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Span<T> AsSpan()
    {
        CheckDisposed();

        return new(_pointer, Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly T* AsPointer()
    {
        CheckDisposed();

        return _pointer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void TransferOwnership(ref T* destination)
    {
        CheckDisposed();

        destination = _pointer;

        _pointer = (T*) nint.Zero;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly void Dispose()
    {
        if ((nint)_pointer != nint.Zero)
        {
            Marshal.FreeHGlobal((nint)_pointer);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        CheckDisposed();

        for (int i = 0; i < Length; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public readonly override string ToString()
    {
        return AsSpan().ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly void CheckDisposed()
    {
        if ((nint)_pointer == nint.Zero)
        {
            throw new ObjectDisposedException(nameof(UnmanagedBuffer<T>));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private readonly void CheckRange(int i)
    {
        if (i < 0 || i >= Length)
        {
            throw new IndexOutOfRangeException(nameof(i));
        }
    }
}
