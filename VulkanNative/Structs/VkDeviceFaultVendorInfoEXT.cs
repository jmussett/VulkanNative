using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultVendorInfoEXT
{
    public fixed char Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public ulong VendorFaultCode;
    public ulong VendorFaultData;
}