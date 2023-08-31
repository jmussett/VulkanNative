using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportFenceCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalFenceHandleTypeFlags handleTypes;

    public VkExportFenceCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO;
    }
}