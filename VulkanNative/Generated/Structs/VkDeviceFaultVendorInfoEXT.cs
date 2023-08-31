using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultVendorInfoEXT
{
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public ulong vendorFaultCode;
    public ulong vendorFaultData;
}