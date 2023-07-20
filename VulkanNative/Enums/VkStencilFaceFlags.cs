namespace VulkanNative;

[Flags]
public enum VkStencilFaceFlags : uint
{
    VK_STENCIL_FACE_FRONT_BIT = 1U << 0,
    VK_STENCIL_FACE_BACK_BIT = 1U << 1,
    VK_STENCIL_FACE_FRONT_AND_BACK = 0x00000003
}