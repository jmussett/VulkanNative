using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDepthBiasInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public float depthBiasConstantFactor;
    public float depthBiasClamp;
    public float depthBiasSlopeFactor;
}