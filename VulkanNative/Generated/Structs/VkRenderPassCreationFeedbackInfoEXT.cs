﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreationFeedbackInfoEXT
{
    public uint postMergeSubpassCount;
}