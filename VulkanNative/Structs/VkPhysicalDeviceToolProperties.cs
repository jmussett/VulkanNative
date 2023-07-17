using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceToolProperties
{
    public VkStructureType sType;
    public void* pNext;
    public char name;
    public char version;
    public VkToolPurposeFlags purposes;
    public char description;
    public char layer;
}