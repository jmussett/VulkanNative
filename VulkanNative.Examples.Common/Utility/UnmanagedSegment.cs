using System;
using System.Runtime.CompilerServices;

namespace VulkanNative.Examples.Common.Utility;

public unsafe readonly struct UnmanagedSegment<TItem> where TItem : unmanaged
{
    private readonly int _length;

    private readonly unsafe TItem* _pointer;

    public readonly int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _length;
    }

    public TItem this[int i]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            CheckRange(i);

            return _pointer[i];
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            CheckRange(i);

            _pointer[i] = value;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedSegment(TItem* pointer, int length)
    {
        _pointer = pointer;
        _length = length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TItem* AsPointer()
    {
        return _pointer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<TItem> AsSpan()
    {
        return new(_pointer, Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedSegment<TItem> Slice(int start, int length)
    {
        if (start < 0 || start + length > _length)
        {
            throw new ArgumentOutOfRangeException();
        }

        return new UnmanagedSegment<TItem>(_pointer + start, length);
    }

    public override string ToString()
    {
        return AsSpan().ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void CheckRange(int i)
    {
        if (i < 0 || i >= _length)
        {
            throw new IndexOutOfRangeException(nameof(i));
        }
    }
}