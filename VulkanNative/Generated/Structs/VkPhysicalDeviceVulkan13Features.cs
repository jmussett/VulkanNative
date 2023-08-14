using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan13Features
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 RobustImageAccess;
    public VkBool32 InlineUniformBlock;
    public VkBool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
    public VkBool32 PipelineCreationCacheControl;
    public VkBool32 PrivateData;
    public VkBool32 ShaderDemoteToHelperInvocation;
    public VkBool32 ShaderTerminateInvocation;
    public VkBool32 SubgroupSizeControl;
    public VkBool32 ComputeFullSubgroups;
    public VkBool32 Synchronization2;
    public VkBool32 TextureCompressionASTCHDR;
    public VkBool32 ShaderZeroInitializeWorkgroupMemory;
    public VkBool32 DynamicRendering;
    public VkBool32 ShaderIntegerDotProduct;
    public VkBool32 Maintenance4;
}