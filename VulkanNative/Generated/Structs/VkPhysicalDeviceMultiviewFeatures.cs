using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 multiview;
    public VkBool32 multiviewGeometryShader;
    public VkBool32 multiviewTessellationShader;

    public VkPhysicalDeviceMultiviewFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES;
    }
}