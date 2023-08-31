using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderTerminateInvocation;

    public VkPhysicalDeviceShaderTerminateInvocationFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES;
    }
}