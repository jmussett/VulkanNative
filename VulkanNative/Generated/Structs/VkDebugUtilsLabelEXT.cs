using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsLabelEXT
{
    public VkStructureType sType;
    public void* pNext;
    public byte* pLabelName;
    public fixed float color[4];

    public VkDebugUtilsLabelEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT;
    }
}