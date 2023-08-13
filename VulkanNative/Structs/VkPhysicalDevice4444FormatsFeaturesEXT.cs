using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 FormatA4R4G4B4;
    public VkBool32 FormatA4B4G4R4;
}