using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkProtectedSubmitInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 protectedSubmit;

    public VkProtectedSubmitInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO;
    }
}