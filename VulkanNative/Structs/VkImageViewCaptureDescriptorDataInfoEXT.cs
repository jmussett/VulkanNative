﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewCaptureDescriptorDataInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageView ImageView;
}