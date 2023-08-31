using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuFunctionCreateInfoNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkCuModuleNVX module;
    public byte* pName;

    public VkCuFunctionCreateInfoNVX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX;
    }
}