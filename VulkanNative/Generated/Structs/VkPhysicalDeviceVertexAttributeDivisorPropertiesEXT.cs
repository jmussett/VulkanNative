using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxVertexAttribDivisor;
}