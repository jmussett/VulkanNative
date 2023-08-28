using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderModuleCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkShaderModuleCreateFlags Flags;
    public nuint CodeSize;
    public uint* PCode;
}