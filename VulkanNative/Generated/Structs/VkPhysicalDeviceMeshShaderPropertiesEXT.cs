using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxTaskWorkGroupTotalCount;
    public fixed uint MaxTaskWorkGroupCount[3];
    public uint MaxTaskWorkGroupInvocations;
    public fixed uint MaxTaskWorkGroupSize[3];
    public uint MaxTaskPayloadSize;
    public uint MaxTaskSharedMemorySize;
    public uint MaxTaskPayloadAndSharedMemorySize;
    public uint MaxMeshWorkGroupTotalCount;
    public fixed uint MaxMeshWorkGroupCount[3];
    public uint MaxMeshWorkGroupInvocations;
    public fixed uint MaxMeshWorkGroupSize[3];
    public uint MaxMeshSharedMemorySize;
    public uint MaxMeshPayloadAndSharedMemorySize;
    public uint MaxMeshOutputMemorySize;
    public uint MaxMeshPayloadAndOutputMemorySize;
    public uint MaxMeshOutputComponents;
    public uint MaxMeshOutputVertices;
    public uint MaxMeshOutputPrimitives;
    public uint MaxMeshOutputLayers;
    public uint MaxMeshMultiviewViewCount;
    public uint MeshOutputPerVertexGranularity;
    public uint MeshOutputPerPrimitiveGranularity;
    public uint MaxPreferredTaskWorkGroupInvocations;
    public uint MaxPreferredMeshWorkGroupInvocations;
    public VkBool32 PrefersLocalInvocationVertexOutput;
    public VkBool32 PrefersLocalInvocationPrimitiveOutput;
    public VkBool32 PrefersCompactVertexOutput;
    public VkBool32 PrefersCompactPrimitiveOutput;
}