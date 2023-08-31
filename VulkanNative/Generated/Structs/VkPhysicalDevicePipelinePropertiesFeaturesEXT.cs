using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 pipelinePropertiesIdentifier;
}