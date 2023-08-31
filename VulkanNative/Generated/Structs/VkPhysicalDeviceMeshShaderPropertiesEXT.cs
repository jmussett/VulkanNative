using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxTaskWorkGroupTotalCount;
    public fixed uint maxTaskWorkGroupCount[3];
    public uint maxTaskWorkGroupInvocations;
    public fixed uint maxTaskWorkGroupSize[3];
    public uint maxTaskPayloadSize;
    public uint maxTaskSharedMemorySize;
    public uint maxTaskPayloadAndSharedMemorySize;
    public uint maxMeshWorkGroupTotalCount;
    public fixed uint maxMeshWorkGroupCount[3];
    public uint maxMeshWorkGroupInvocations;
    public fixed uint maxMeshWorkGroupSize[3];
    public uint maxMeshSharedMemorySize;
    public uint maxMeshPayloadAndSharedMemorySize;
    public uint maxMeshOutputMemorySize;
    public uint maxMeshPayloadAndOutputMemorySize;
    public uint maxMeshOutputComponents;
    public uint maxMeshOutputVertices;
    public uint maxMeshOutputPrimitives;
    public uint maxMeshOutputLayers;
    public uint maxMeshMultiviewViewCount;
    public uint meshOutputPerVertexGranularity;
    public uint meshOutputPerPrimitiveGranularity;
    public uint maxPreferredTaskWorkGroupInvocations;
    public uint maxPreferredMeshWorkGroupInvocations;
    public VkBool32 prefersLocalInvocationVertexOutput;
    public VkBool32 prefersLocalInvocationPrimitiveOutput;
    public VkBool32 prefersCompactVertexOutput;
    public VkBool32 prefersCompactPrimitiveOutput;
}