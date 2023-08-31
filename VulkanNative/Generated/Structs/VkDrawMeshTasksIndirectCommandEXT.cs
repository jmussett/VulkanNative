using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrawMeshTasksIndirectCommandEXT
{
    public uint groupCountX;
    public uint groupCountY;
    public uint groupCountZ;
}