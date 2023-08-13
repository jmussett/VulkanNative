using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTraceRaysIndirectCommand2KHR
{
    public VkDeviceAddress RaygenShaderRecordAddress;
    public VkDeviceSize RaygenShaderRecordSize;
    public VkDeviceAddress MissShaderBindingTableAddress;
    public VkDeviceSize MissShaderBindingTableSize;
    public VkDeviceSize MissShaderBindingTableStride;
    public VkDeviceAddress HitShaderBindingTableAddress;
    public VkDeviceSize HitShaderBindingTableSize;
    public VkDeviceSize HitShaderBindingTableStride;
    public VkDeviceAddress CallableShaderBindingTableAddress;
    public VkDeviceSize CallableShaderBindingTableSize;
    public VkDeviceSize CallableShaderBindingTableStride;
    public uint Width;
    public uint Height;
    public uint Depth;
}