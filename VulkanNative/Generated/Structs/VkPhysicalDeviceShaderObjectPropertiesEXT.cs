using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderObjectPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public fixed byte ShaderBinaryUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public uint ShaderBinaryVersion;
}