using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportScreenBufferInfoQNX
{
    public VkStructureType sType;
    public void* pNext;
    public nint* buffer;

    public VkImportScreenBufferInfoQNX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX;
    }
}