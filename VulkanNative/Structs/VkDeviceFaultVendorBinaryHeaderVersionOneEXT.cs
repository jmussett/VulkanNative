using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
    public uint HeaderSize;
    public VkDeviceFaultVendorBinaryHeaderVersionEXT HeaderVersion;
    public uint VendorID;
    public uint DeviceID;
    public uint DriverVersion;
    public fixed byte PipelineCacheUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public uint ApplicationNameOffset;
    public uint ApplicationVersion;
    public uint EngineNameOffset;
    public uint EngineVersion;
    public uint ApiVersion;
}