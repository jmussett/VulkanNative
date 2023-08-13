using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceToolProperties
{
    public VkStructureType SType;
    public void* PNext;
    public fixed char Name[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public fixed char Version[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public VkToolPurposeFlags Purposes;
    public fixed char Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed char Layer[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
}