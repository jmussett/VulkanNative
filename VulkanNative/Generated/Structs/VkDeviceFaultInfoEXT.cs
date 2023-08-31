using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public VkDeviceFaultAddressInfoEXT* pAddressInfos;
    public VkDeviceFaultVendorInfoEXT* pVendorInfos;
    public void* pVendorBinaryData;
}