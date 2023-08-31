using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
    public uint headerSize;
    public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
    public uint vendorID;
    public uint deviceID;
    public uint driverVersion;
    public fixed byte pipelineCacheUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public uint applicationNameOffset;
    public uint applicationVersion;
    public uint engineNameOffset;
    public uint engineVersion;
    public uint apiVersion;
}