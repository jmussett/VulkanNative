using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Glfw;

public delegate void ErrorCallback(int code, string message);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void GLFWerrorfun(int error, byte* description);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SizeCallback(GlfwWindow window, int width, int height);
