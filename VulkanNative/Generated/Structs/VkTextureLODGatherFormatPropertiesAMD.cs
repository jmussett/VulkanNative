using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTextureLODGatherFormatPropertiesAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 supportsTextureGatherLODBiasAMD;

    public VkTextureLODGatherFormatPropertiesAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD;
    }
}