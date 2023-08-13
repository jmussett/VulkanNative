using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
{
    public VkStructureType SType;
    public void* PNext;
    public uint ShaderEngineCount;
    public uint ShaderArraysPerEngineCount;
    public uint ComputeUnitsPerShaderArray;
    public uint SimdPerComputeUnit;
    public uint WavefrontsPerSimd;
    public uint WavefrontSize;
    public uint SgprsPerSimd;
    public uint MinSgprAllocation;
    public uint MaxSgprAllocation;
    public uint SgprAllocationGranularity;
    public uint VgprsPerSimd;
    public uint MinVgprAllocation;
    public uint MaxVgprAllocation;
    public uint VgprAllocationGranularity;
}