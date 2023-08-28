using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsObjectTagInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkObjectType ObjectType;
    public ulong ObjectHandle;
    public ulong TagName;
    public nuint TagSize;
    public void* PTag;
}