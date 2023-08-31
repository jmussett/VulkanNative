using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDirectDriverLoadingInfoLUNARG
{
    public VkStructureType sType;
    public void* pNext;
    public VkDirectDriverLoadingFlagsLUNARG flags;
    public delegate* unmanaged[Cdecl]<VkInstance, byte*, void> pfnGetInstanceProcAddr;

    public VkDirectDriverLoadingInfoLUNARG()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG;
    }
}