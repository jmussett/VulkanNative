using System;
using System.Collections.Generic;

namespace VulkanNative.Examples.Common.Utility;

public unsafe interface IUnmanaged<TItem> : IEnumerable<TItem>, IDisposable
    where TItem : unmanaged
{
    TItem this[int i] { get; set; }
    int Length { get; }
    void TransferOwnership(ref TItem* destination);
    Span<TItem> AsSpan();
    TItem* AsPointer();
}