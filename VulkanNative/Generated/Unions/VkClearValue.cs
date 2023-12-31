﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearValue
{
    [FieldOffset(0)]
    public VkClearColorValue color;
    [FieldOffset(0)]
    public VkClearDepthStencilValue depthStencil;
}