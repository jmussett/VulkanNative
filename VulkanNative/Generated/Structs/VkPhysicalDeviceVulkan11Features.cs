using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan11Features
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 storageBuffer16BitAccess;
    public VkBool32 uniformAndStorageBuffer16BitAccess;
    public VkBool32 storagePushConstant16;
    public VkBool32 storageInputOutput16;
    public VkBool32 multiview;
    public VkBool32 multiviewGeometryShader;
    public VkBool32 multiviewTessellationShader;
    public VkBool32 variablePointersStorageBuffer;
    public VkBool32 variablePointers;
    public VkBool32 protectedMemory;
    public VkBool32 samplerYcbcrConversion;
    public VkBool32 shaderDrawParameters;
}