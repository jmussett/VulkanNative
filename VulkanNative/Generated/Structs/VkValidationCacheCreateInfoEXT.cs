using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkValidationCacheCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkValidationCacheCreateFlagsEXT Flags;
    public nuint InitialDataSize;
    public void* PInitialData;
}