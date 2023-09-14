using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Utility;

public sealed unsafe class UnmanagedNullable<TItem> : IUnmanaged<TItem>
    where TItem : unmanaged
{
    private TItem* _pointer;
    private bool _disposed = false;

    public TItem this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            CheckDisposed();

            if ((nint)_pointer == nint.Zero)
            {
                throw new NullReferenceException();
            }

            if (index != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return _pointer[index];
        }
        set => throw new NotSupportedException();
    }

    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (nint)_pointer != nint.Zero ? 1 : 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedNullable(TItem? value)
    {
        if (value is not null)
        {
            _pointer = (TItem*)Marshal.AllocHGlobal(sizeof(TItem));
            _pointer[0] = value.Value;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TItem* AsPointer()
    {
        CheckDisposed();

        return _pointer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<TItem> AsSpan()
    {
        CheckDisposed();

        return new(_pointer, Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void TransferOwnership(ref TItem* destination)
    {
        CheckDisposed();

        destination = _pointer;

        _pointer = null;
        _disposed = true;
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            if ((nint)_pointer != nint.Zero)
            {
                Marshal.FreeHGlobal((nint)_pointer);
            }
            
            _disposed = true;

            GC.SuppressFinalize(this);
        }
    }

    ~UnmanagedNullable()
    {
        Dispose();
    }

    public IEnumerator<TItem> GetEnumerator()
    {
        throw new NotSupportedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void CheckDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(UnmanagedNullable<TItem>));
        }
    }
}
