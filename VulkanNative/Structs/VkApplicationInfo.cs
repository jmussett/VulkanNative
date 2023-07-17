using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkApplicationInfo
{
    public VkStructureType sType;
    public void* pNext;
    public char* pApplicationName;
    public uint applicationVersion;
    public char* pEngineName;
    public uint engineVersion;
    public uint apiVersion;
}