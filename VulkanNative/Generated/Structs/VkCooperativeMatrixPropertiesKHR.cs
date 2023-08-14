using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCooperativeMatrixPropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MSize;
    public uint NSize;
    public uint KSize;
    public VkComponentTypeKHR AType;
    public VkComponentTypeKHR BType;
    public VkComponentTypeKHR CType;
    public VkComponentTypeKHR ResultType;
    public VkBool32 SaturatingAccumulation;
    public VkScopeKHR Scope;
}