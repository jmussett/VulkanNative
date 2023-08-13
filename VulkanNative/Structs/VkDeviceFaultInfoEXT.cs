using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public fixed char Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public VkDeviceFaultAddressInfoEXT* PAddressInfos;
    public VkDeviceFaultVendorInfoEXT* PVendorInfos;
    public void* PVendorBinaryData;
}