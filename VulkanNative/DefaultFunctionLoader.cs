using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VulkanNative.Abstractions;

namespace VulkanNative;

internal unsafe class DefaultFunctionLoader : IFunctionLoader
{
    private readonly IntPtr _libraryHandle;

    private delegate* unmanaged[Cdecl]<VkInstance, char*, IntPtr> _vkGetInstanceProcAddr;
    private delegate* unmanaged[Cdecl]<VkDevice, char*, IntPtr> _vkGetDeviceProcAddr;

    public DefaultFunctionLoader()
    {
        string libraryName = GetVulkanLibraryName();
        
        var _libraryHandle = NativeLibrary.Load(libraryName);

        if (_libraryHandle == IntPtr.Zero)
        {
            throw new Exception($"Failed to load Vulkan library: {libraryName}");
        }

        _vkGetInstanceProcAddr = (delegate* unmanaged[Cdecl]<VkInstance, char*, IntPtr>) GetProcAddr("vkGetInstanceProcAddr");
        _vkGetDeviceProcAddr = (delegate* unmanaged[Cdecl]<VkDevice, char*, IntPtr>) GetProcAddr("vkGetDeviceProcAddr");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public nint GetInstanceProcAddr(VkInstance instance, string name)
    {
        fixed (char* namePtr = name)
        {
            return _vkGetInstanceProcAddr(instance, namePtr);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public nint GetDeviceProcAddr(VkDevice device, string name)
    {
        fixed (char* namePtr = name)
        {
            return _vkGetDeviceProcAddr(device, namePtr);
        }
    }

    public nint GetProcAddr(string name)
    {
        return NativeLibrary.GetExport(_libraryHandle, name);
    }

    private static string GetVulkanLibraryName()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return "vulkan-1.dll";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return "libvulkan.so.1";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) || RuntimeInformation.IsOSPlatform(OSPlatform.Create("IOS")))
        {
            return "libMoltenVK.dylib";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("ANDROID")))
        {
            return "libvulkan.so";
        }
        else
        {
            throw new PlatformNotSupportedException("Unsupported platform for Vulkan.");
        }
    }
}
