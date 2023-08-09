using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceToolProperties
{
    public VkStructureType sType;
    public void* pNext;
    public fixed char name[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public fixed char version[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public VkToolPurposeFlags purposes;
    public fixed char description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed char layer[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
}