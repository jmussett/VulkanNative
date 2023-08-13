using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkApplicationInfo
{
    public VkStructureType SType;
    public void* PNext;
    public char* PApplicationName;
    public uint ApplicationVersion;
    public char* PEngineName;
    public uint EngineVersion;
    public uint ApiVersion;
}