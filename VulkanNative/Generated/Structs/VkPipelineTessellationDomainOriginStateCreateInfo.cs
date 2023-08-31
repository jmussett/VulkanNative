using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkTessellationDomainOrigin domainOrigin;

    public VkPipelineTessellationDomainOriginStateCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO;
    }
}