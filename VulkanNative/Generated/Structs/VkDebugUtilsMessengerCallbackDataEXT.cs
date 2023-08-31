using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
    public byte* pMessageIdName;
    public int messageIdNumber;
    public byte* pMessage;
    public uint queueLabelCount;
    public VkDebugUtilsLabelEXT* pQueueLabels;
    public uint cmdBufLabelCount;
    public VkDebugUtilsLabelEXT* pCmdBufLabels;
    public uint objectCount;
    public VkDebugUtilsObjectNameInfoEXT* pObjects;
}