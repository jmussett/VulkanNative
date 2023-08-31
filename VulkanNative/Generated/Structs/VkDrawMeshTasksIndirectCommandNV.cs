using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrawMeshTasksIndirectCommandNV
{
    public uint taskCount;
    public uint firstTask;
}