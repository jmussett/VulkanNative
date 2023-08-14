using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkResolveModeFlags SupportedDepthResolveModes;
    public VkResolveModeFlags SupportedStencilResolveModes;
    public VkBool32 IndependentResolveNone;
    public VkBool32 IndependentResolve;
}