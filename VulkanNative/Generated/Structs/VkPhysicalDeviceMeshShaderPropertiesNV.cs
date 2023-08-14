using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxDrawMeshTasksCount;
    public uint MaxTaskWorkGroupInvocations;
    public fixed uint MaxTaskWorkGroupSize[3];
    public uint MaxTaskTotalMemorySize;
    public uint MaxTaskOutputCount;
    public uint MaxMeshWorkGroupInvocations;
    public fixed uint MaxMeshWorkGroupSize[3];
    public uint MaxMeshTotalMemorySize;
    public uint MaxMeshOutputVertices;
    public uint MaxMeshOutputPrimitives;
    public uint MaxMeshMultiviewViewCount;
    public uint MeshOutputPerVertexGranularity;
    public uint MeshOutputPerPrimitiveGranularity;
}