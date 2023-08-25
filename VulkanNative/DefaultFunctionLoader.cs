using System.Runtime.InteropServices;
using System.Text;
using VulkanNative.Abstractions;

namespace VulkanNative;

internal unsafe class DefaultFunctionLoader : IFunctionLoader
{
    private readonly nint _libraryHandle;

    private readonly delegate* unmanaged[Cdecl]<VkInstance, byte*, nint> _vkGetInstanceProcAddr;
    private readonly delegate* unmanaged[Cdecl]<VkDevice, byte*, nint> _vkGetDeviceProcAddr;

    public DefaultFunctionLoader()
    {
        string libraryName = GetVulkanLibraryName();
        
        _libraryHandle = NativeLibrary.Load(libraryName);

        // TODO: Consider a soft-fail mechanism in release mode
        if (_libraryHandle == nint.Zero)
        {
            throw new FileNotFoundException($"Failed to load Vulkan library: {libraryName}");
        }

        _vkGetInstanceProcAddr = (delegate* unmanaged[Cdecl]<VkInstance, byte*, nint>) GetProcAddr("vkGetInstanceProcAddr");
        _vkGetDeviceProcAddr = (delegate* unmanaged[Cdecl]<VkDevice, byte*, nint>) GetProcAddr("vkGetDeviceProcAddr");

        if (_vkGetInstanceProcAddr == null)
        {
            throw new InvalidOperationException($"Failed to load function pointer: vkGetInstanceProcAddr");
        }

        if (_vkGetDeviceProcAddr == null)
        {
            throw new InvalidOperationException($"Failed to load function pointer: vkGetDeviceProcAddr");
        }
    }

    public nint GetInstanceProcAddr(VkInstance instance, ReadOnlySpan<char> name)
    {
        var byteCount = Encoding.UTF8.GetByteCount(name);

        Span<byte> bytes = stackalloc byte[byteCount];

        _ = Encoding.UTF8.GetBytes(name, bytes);

        fixed (byte* namePtr = bytes)
        {
            return _vkGetInstanceProcAddr(instance, namePtr);
        }
    }

    public nint GetDeviceProcAddr(VkDevice device, ReadOnlySpan<char> name)
    {
        var byteCount = Encoding.UTF8.GetByteCount(name);

        Span<byte> bytes = stackalloc byte[byteCount];

        _ = Encoding.UTF8.GetBytes(name, bytes);

        fixed (byte* namePtr = bytes)
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
