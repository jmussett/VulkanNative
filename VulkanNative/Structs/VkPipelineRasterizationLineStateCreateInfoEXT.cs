using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkLineRasterizationModeEXT LineRasterizationMode;
    public VkBool32 StippledLineEnable;
    public uint LineStippleFactor;
    public ushort LineStipplePattern;
}