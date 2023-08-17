using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceToolProperties
{
    public VkStructureType SType;
    public void* PNext;
    public fixed byte Name[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public fixed byte Version[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public VkToolPurposeFlags Purposes;
    public fixed byte Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte Layer[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
}