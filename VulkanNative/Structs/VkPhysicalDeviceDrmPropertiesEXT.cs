using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 HasPrimary;
    public VkBool32 HasRender;
    public long PrimaryMajor;
    public long PrimaryMinor;
    public long RenderMajor;
    public long RenderMinor;
}