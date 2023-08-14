using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTilePropertiesQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkExtent3D TileSize;
    public VkExtent2D ApronSize;
    public VkOffset2D Origin;
}