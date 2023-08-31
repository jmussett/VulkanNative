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
}