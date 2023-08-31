using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderDemoteToHelperInvocation;

    public VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES;
    }
}