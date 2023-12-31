﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkApplicationInfo
{
    public VkStructureType sType;
    public void* pNext;
    public byte* pApplicationName;
    public uint applicationVersion;
    public byte* pEngineName;
    public uint engineVersion;
    public uint apiVersion;

    public VkApplicationInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO;
    }
}