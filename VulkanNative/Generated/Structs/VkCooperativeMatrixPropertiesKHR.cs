using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCooperativeMatrixPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint MSize;
    public uint NSize;
    public uint KSize;
    public VkComponentTypeKHR AType;
    public VkComponentTypeKHR BType;
    public VkComponentTypeKHR CType;
    public VkComponentTypeKHR ResultType;
    public VkBool32 saturatingAccumulation;
    public VkScopeKHR scope;

    public VkCooperativeMatrixPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR;
    }
}