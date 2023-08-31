using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCorePropertiesARM
{
    public VkStructureType sType;
    public void* pNext;
    public uint pixelRate;
    public uint texelRate;
    public uint fmaRate;
}