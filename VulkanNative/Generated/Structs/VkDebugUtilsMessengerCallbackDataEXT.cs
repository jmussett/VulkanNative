using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDebugUtilsMessengerCallbackDataFlagsEXT Flags;
    public char* PMessageIdName;
    public int MessageIdNumber;
    public char* PMessage;
    public uint QueueLabelCount;
    public VkDebugUtilsLabelEXT* PQueueLabels;
    public uint CmdBufLabelCount;
    public VkDebugUtilsLabelEXT* PCmdBufLabels;
    public uint ObjectCount;
    public VkDebugUtilsObjectNameInfoEXT* PObjects;
}