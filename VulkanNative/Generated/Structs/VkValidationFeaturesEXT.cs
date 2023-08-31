using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkValidationFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint enabledValidationFeatureCount;
    public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
    public uint disabledValidationFeatureCount;
    public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
}