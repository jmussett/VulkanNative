using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceAddressBindingCallbackDataEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceAddressBindingFlagsEXT Flags;
    public VkDeviceAddress BaseAddress;
    public VkDeviceSize Size;
    public VkDeviceAddressBindingTypeEXT BindingType;
}