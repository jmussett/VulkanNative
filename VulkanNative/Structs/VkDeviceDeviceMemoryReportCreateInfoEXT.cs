using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceMemoryReportFlagsEXT Flags;
    public delegate* unmanaged[Cdecl]<VkDeviceMemoryReportCallbackDataEXT*, void*, void> PfnUserCallback;
    public void* PUserData;
}