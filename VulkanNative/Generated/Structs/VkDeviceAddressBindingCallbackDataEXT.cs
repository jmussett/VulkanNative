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

    public VkDeviceAddressBindingCallbackDataEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT;
    }
}