using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceAddressBindingCallbackDataEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceAddressBindingFlagsEXT flags;
    public VkDeviceAddress baseAddress;
    public VkDeviceSize size;
    public VkDeviceAddressBindingTypeEXT bindingType;
}