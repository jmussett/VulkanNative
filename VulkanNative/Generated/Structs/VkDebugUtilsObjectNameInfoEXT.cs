using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsObjectNameInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkObjectType objectType;
    public ulong objectHandle;
    public byte* pObjectName;

    public VkDebugUtilsObjectNameInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT;
    }
}