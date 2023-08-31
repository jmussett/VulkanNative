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
}