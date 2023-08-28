using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Glfw;

public unsafe class GlfwVulkan
{
    private readonly GlfwVulkanCommands _commands;

    public GlfwVulkan(nint libraryHandle)
    {
        _commands = new GlfwVulkanCommands(libraryHandle);
    }

    public bool IsVulkanSupported()
    {
        return _commands.glfwVulkanSupported();
    }

    public string[] GetRequiredInstanceExtensions()
    {
        uint count;
        var extensionsPtr = (nint*)_commands.glfwGetRequiredInstanceExtensions(&count);

        if (extensionsPtr == null || count == 0)
            return Array.Empty<string>();

        var extensions = new string[count];

        for (uint i = 0; i < count; i++)
        {
            extensions[i] = Marshal.PtrToStringUTF8(extensionsPtr[i])!;
        }

        return extensions;
    }

    public int CreateWindowSurface(nint instance, GlfwWindow window, nint? allocator, out nint surface)
    {
        fixed (nint* surfacePtr = &surface)
            return _commands.glfwCreateWindowSurface(instance, window, allocator ?? nint.Zero, surfacePtr);
    }
}
