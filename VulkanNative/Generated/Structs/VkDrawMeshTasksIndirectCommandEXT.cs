using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrawMeshTasksIndirectCommandEXT
{
    public uint GroupCountX;
    public uint GroupCountY;
    public uint GroupCountZ;
}