using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiviewPerViewAttributesInfoNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 perViewAttributes;
    public VkBool32 perViewAttributesPositionXOnly;

    public VkMultiviewPerViewAttributesInfoNVX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX;
    }
}