using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkValidationFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint EnabledValidationFeatureCount;
    public VkValidationFeatureEnableEXT* PEnabledValidationFeatures;
    public uint DisabledValidationFeatureCount;
    public VkValidationFeatureDisableEXT* PDisabledValidationFeatures;
}