using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkLineRasterizationModeEXT lineRasterizationMode;
    public VkBool32 stippledLineEnable;
    public uint lineStippleFactor;
    public ushort lineStipplePattern;
}