using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
{
    public VkStructureType sType;
    public void* pNext;
    public uint shaderEngineCount;
    public uint shaderArraysPerEngineCount;
    public uint computeUnitsPerShaderArray;
    public uint simdPerComputeUnit;
    public uint wavefrontsPerSimd;
    public uint wavefrontSize;
    public uint sgprsPerSimd;
    public uint minSgprAllocation;
    public uint maxSgprAllocation;
    public uint sgprAllocationGranularity;
    public uint vgprsPerSimd;
    public uint minVgprAllocation;
    public uint maxVgprAllocation;
    public uint vgprAllocationGranularity;
}