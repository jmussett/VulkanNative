using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyCommandTransformInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceTransformFlagsKHR transform;

    public VkCopyCommandTransformInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM;
    }
}