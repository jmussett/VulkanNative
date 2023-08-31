using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTraceRaysIndirectCommand2KHR
{
    public VkDeviceAddress raygenShaderRecordAddress;
    public VkDeviceSize raygenShaderRecordSize;
    public VkDeviceAddress missShaderBindingTableAddress;
    public VkDeviceSize missShaderBindingTableSize;
    public VkDeviceSize missShaderBindingTableStride;
    public VkDeviceAddress hitShaderBindingTableAddress;
    public VkDeviceSize hitShaderBindingTableSize;
    public VkDeviceSize hitShaderBindingTableStride;
    public VkDeviceAddress callableShaderBindingTableAddress;
    public VkDeviceSize callableShaderBindingTableSize;
    public VkDeviceSize callableShaderBindingTableStride;
    public uint width;
    public uint height;
    public uint depth;
}