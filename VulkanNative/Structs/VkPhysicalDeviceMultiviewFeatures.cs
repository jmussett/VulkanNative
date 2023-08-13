using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 Multiview;
    public VkBool32 MultiviewGeometryShader;
    public VkBool32 MultiviewTessellationShader;
}