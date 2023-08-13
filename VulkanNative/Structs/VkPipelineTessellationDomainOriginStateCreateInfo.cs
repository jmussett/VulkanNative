using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkTessellationDomainOrigin domainOrigin;
}