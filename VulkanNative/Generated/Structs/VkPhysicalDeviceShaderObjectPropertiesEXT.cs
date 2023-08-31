using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderObjectPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte shaderBinaryUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public uint shaderBinaryVersion;
}