using System.Runtime.InteropServices;
using VulkanNative.Abstractions;

namespace VulkanNative;

internal unsafe class DefaultFunctionLoader : IFunctionLoader
{
    private readonly nint _libraryHandle;

    private readonly delegate* unmanaged[Cdecl]<VkInstance, char*, nint> _vkGetInstanceProcAddr;
    private readonly delegate* unmanaged[Cdecl]<VkDevice, char*, nint> _vkGetDeviceProcAddr;

    public DefaultFunctionLoader()
    {
        string libraryName = GetVulkanLibraryName();
        
        _libraryHandle = NativeLibrary.Load(libraryName);

        // TODO: Consider a soft-fail mechanism in release mode
        if (_libraryHandle == nint.Zero)
        {
            throw new FileNotFoundException($"Failed to load Vulkan library: {libraryName}");
        }

        _vkGetInstanceProcAddr = (delegate* unmanaged[Cdecl]<VkInstance, char*, nint>) GetProcAddr("vkGetInstanceProcAddr");
        _vkGetDeviceProcAddr = (delegate* unmanaged[Cdecl]<VkDevice, char*, nint>) GetProcAddr("vkGetDeviceProcAddr");
    }

    public nint GetInstanceProcAddr(VkInstance instance, string name)
    {
        fixed (char* namePtr = name)
        {
            var addr = _vkGetInstanceProcAddr(instance, namePtr);

            // TODO: Consider a soft-fail mechanism in release mode
            if (addr == nint.Zero)
            {
                throw new InvalidOperationException($"Failed to load instance function pointer: {name}");
            }

            return addr;
        }
    }

    public nint GetDeviceProcAddr(VkDevice device, string name)
    {
        fixed (char* namePtr = name)
        {
            var addr = _vkGetDeviceProcAddr(device, namePtr);

            // TODO: Consider a soft-fail mechanism in release mode
            if (addr == nint.Zero)
            {
                throw new InvalidOperationException($"Failed to load device function pointer: {name}");
            }

            return addr;
        }
    }

    public nint GetProcAddr(string name)
    {
        var addr = NativeLibrary.GetExport(_libraryHandle, name);

        // TODO: Consider a soft-fail mechanism in release mode
        if (addr == nint.Zero)
        {
            throw new InvalidOperationException($"Failed to load function pointer: {name}");
        }

        return addr;
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
