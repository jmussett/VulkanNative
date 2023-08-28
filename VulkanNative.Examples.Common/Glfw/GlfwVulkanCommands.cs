using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Glfw;

internal unsafe class GlfwVulkanCommands
{
    public delegate* unmanaged[Cdecl]<bool> glfwVulkanSupported;
    public delegate* unmanaged[Cdecl]<uint*, nint> glfwGetRequiredInstanceExtensions;
    public delegate* unmanaged[Cdecl]<nint, GlfwWindow, nint, nint*, int> glfwCreateWindowSurface;

    public GlfwVulkanCommands(nint libraryHandle)
    {
        glfwVulkanSupported = (delegate* unmanaged[Cdecl]<bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwVulkanSupported");

        glfwGetRequiredInstanceExtensions = (delegate* unmanaged[Cdecl]<uint*, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetRequiredInstanceExtensions");

        glfwCreateWindowSurface = (delegate* unmanaged[Cdecl]<nint, GlfwWindow, nint, nint*, int>)
            NativeLibrary.GetExport(libraryHandle, "glfwCreateWindowSurface");
    }
}
