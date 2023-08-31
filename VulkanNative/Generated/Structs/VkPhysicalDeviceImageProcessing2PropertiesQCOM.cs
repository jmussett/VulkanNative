using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessing2PropertiesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D maxBlockMatchWindow;
}