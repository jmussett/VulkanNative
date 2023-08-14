using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
{
    public VkStructureType SType;
    public void* PNext;
    public ulong ShaderCoreMask;
    public uint ShaderCoreCount;
    public uint ShaderWarpsPerCore;
}