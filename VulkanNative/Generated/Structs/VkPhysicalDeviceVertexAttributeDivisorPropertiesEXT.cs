using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxVertexAttribDivisor;

    public VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT;
    }
}