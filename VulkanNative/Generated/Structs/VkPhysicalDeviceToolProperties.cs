using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceToolProperties
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte name[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public fixed byte version[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public VkToolPurposeFlags purposes;
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte layer[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];

    public VkPhysicalDeviceToolProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES;
    }
}