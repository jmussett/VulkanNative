using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutableInternalRepresentationKHR
{
    public VkStructureType SType;
    public void* PNext;
    public fixed char Name[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed char Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public VkBool32 IsText;
    public nint DataSize;
    public void* PData;
}