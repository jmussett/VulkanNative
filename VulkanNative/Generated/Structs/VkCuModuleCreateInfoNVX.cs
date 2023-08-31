using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuModuleCreateInfoNVX
{
    public VkStructureType sType;
    public void* pNext;
    public nuint dataSize;
    public void* pData;

    public VkCuModuleCreateInfoNVX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX;
    }
}