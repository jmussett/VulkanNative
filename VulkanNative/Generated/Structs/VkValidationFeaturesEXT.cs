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

    public VkValidationFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT;
    }
}