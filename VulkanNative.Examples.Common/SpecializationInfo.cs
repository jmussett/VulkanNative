using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common;

public sealed unsafe class SpecializationInfo : IDisposable
{
    private VkSpecializationInfo _vkSpecInfo;

    private const nuint InitialEntryCount = 10;
    private const nuint InitialDataSize = 100;

    private nuint _currentEntrySize = InitialEntryCount;
    private nuint _currentDataSize = InitialDataSize;

    internal VkSpecializationInfo Handle => _vkSpecInfo;

    public SpecializationInfo()
    {
        _vkSpecInfo.pMapEntries = (VkSpecializationMapEntry*) Marshal.AllocHGlobal(sizeof(VkSpecializationMapEntry) * (int) InitialEntryCount);
        _vkSpecInfo.pData = (void*) Marshal.AllocHGlobal((int)InitialDataSize);
        _vkSpecInfo.mapEntryCount = 0;
        _vkSpecInfo.dataSize = 0;
    }

    public void AddConstant<T>(int constantId, T constant) where T : unmanaged
    {
        nuint byteSize = (nuint)sizeof(T);

        // Resize if necessary
        if (_vkSpecInfo.mapEntryCount == _currentEntrySize)
        {
            _currentEntrySize *= 2;
            _vkSpecInfo.pMapEntries = (VkSpecializationMapEntry*)Marshal.ReAllocHGlobal((nint)_vkSpecInfo.pMapEntries, (nint)(sizeof(VkSpecializationMapEntry) * (uint)_currentEntrySize));
        }

        if (_vkSpecInfo.dataSize + byteSize > _currentDataSize)
        {
            _currentDataSize *= 2;
            _vkSpecInfo.pData = (void*) Marshal.ReAllocHGlobal((nint)_vkSpecInfo.pData, (nint)_currentDataSize);
        }

        _vkSpecInfo.pMapEntries[_vkSpecInfo.mapEntryCount] = new()
        {
            constantID = (uint)constantId,
            offset = (uint)_vkSpecInfo.dataSize,
            size = byteSize
        };

        _vkSpecInfo.mapEntryCount++;

        var sourceSpan = new ReadOnlySpan<T>(&constant, 1);
        var targetSpan = new Span<byte>((byte*)_vkSpecInfo.pData + _vkSpecInfo.dataSize, (int)byteSize);
        MemoryMarshal.Cast<T, byte>(sourceSpan).CopyTo(targetSpan);
        _vkSpecInfo.dataSize += byteSize;
    }

    public void Dispose()
    {
        if ((nint)_vkSpecInfo.pMapEntries != nint.Zero)
        {
            Marshal.FreeHGlobal((nint)_vkSpecInfo.pMapEntries);
            _vkSpecInfo.pMapEntries = null;
        }

        if ((nint)_vkSpecInfo.pData != nint.Zero)
        {
            Marshal.FreeHGlobal((nint)_vkSpecInfo.pData);
            _vkSpecInfo.pData = null;
        }

        GC.SuppressFinalize(this);
    }

    ~SpecializationInfo()
    {
        Dispose();
    }
}