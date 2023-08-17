using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsLabelEXT
{
    public VkStructureType SType;
    public void* PNext;
    public byte* PLabelName;
    public fixed float Color[4];
}