using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 formatA4R4G4B4;
    public VkBool32 formatA4B4G4R4;
}