using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Glfw;

public delegate void ErrorCallback(int code, string message);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void GLFWerrorfun(int error, byte* description);