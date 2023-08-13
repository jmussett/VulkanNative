namespace VulkanNative;

[Flags]
public enum VkVideoCodecOperationFlagsKHR : uint
{
    VK_VIDEO_CODEC_OPERATION_NONE_KHR = 0,
    VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR = 1U << 0,
    VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR = 1U << 1
}