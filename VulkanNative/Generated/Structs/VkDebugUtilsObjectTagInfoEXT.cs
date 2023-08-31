using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsObjectTagInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkObjectType objectType;
    public ulong objectHandle;
    public ulong tagName;
    public nuint tagSize;
    public void* pTag;

    public VkDebugUtilsObjectTagInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT;
    }
}