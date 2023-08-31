using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 representativeFragmentTestEnable;

    public VkPipelineRepresentativeFragmentTestStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV;
    }
}