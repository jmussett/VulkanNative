using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkResolveModeFlags supportedDepthResolveModes;
    public VkResolveModeFlags supportedStencilResolveModes;
    public VkBool32 independentResolveNone;
    public VkBool32 independentResolve;
}