using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoSessionParametersCreateFlagsKHR flags;
    public VkVideoSessionParametersKHR videoSessionParametersTemplate;
    public VkVideoSessionKHR videoSession;
}