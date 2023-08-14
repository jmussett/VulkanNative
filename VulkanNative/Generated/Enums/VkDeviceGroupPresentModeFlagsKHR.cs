﻿namespace VulkanNative;

[Flags]
public enum VkDeviceGroupPresentModeFlagsKHR : uint
{
    VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR = 1U << 0,
    VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR = 1U << 1,
    VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR = 1U << 2,
    VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR = 1U << 3
}