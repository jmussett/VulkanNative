using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe class Glfw
{
    private static bool _disposed;
    private static readonly nint _libraryHandle;
    private static readonly GlfwCommands _commands;

    private static GlfwVulkan? _vulkan;

    public static GlfwVulkan Vulkan
    {
        get
        {
            CheckDisposed();

            _vulkan ??= new GlfwVulkan(_libraryHandle);

            return _vulkan;
        }
    }

    static Glfw()
    {
        var libraryName = GetLibraryName();
        _libraryHandle = NativeLibrary.Load(libraryName);

        _commands = new GlfwCommands(_libraryHandle);
        _commands.glfwInit();
    }

    private static string GetLibraryName()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return "glfw3";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return "libglfw.3";
        }
        else
        {
            return "glfw";
        }
    }

    public static void Terminate()
    {
        CheckDisposed();

        _commands.glfwTerminate();

        if (_errorCallbackHandle.IsAllocated)
        {
            _errorCallbackHandle.Free();
        }

        // TODO
        //_commands.Dispose();
        _disposed = true;
    }

    private static GCHandle _errorCallbackHandle;
    private static ErrorCallback? _errorCallback;

    public static void SetErrorCallback(ErrorCallback errorCallback)
    {
        CheckDisposed();

        GLFWerrorfun callback = GlfwErrorCallback;

        if (_errorCallbackHandle.IsAllocated)
        {
            _errorCallbackHandle.Free();
        }

        _errorCallbackHandle = GCHandle.Alloc(callback, GCHandleType.Normal);

        var glfwErrorCallback = Marshal.GetFunctionPointerForDelegate(callback);

        _commands.glfwSetErrorCallback(glfwErrorCallback);
        _errorCallback = errorCallback;
    }

    private static void GlfwErrorCallback(int code, byte* messagePtr)
    {
        var message = Marshal.PtrToStringUTF8((nint) messagePtr)!;

        _errorCallback!(code, message);
    }

    public static void WindowHint(Hint hint, int value)
    {
        CheckDisposed();
        _commands.glfwWindowHint(hint, value);
    }

    public static void WindowHint(Hint hint, bool value)
    {
        WindowHint(hint, value ? 1 : 0);
    }

    public static GlfwWindow CreateWindow(int width, int height, ReadOnlySpan<char> title, GlfwMonitor? monitor = null, GlfwWindow? share = null)
    {
        CheckDisposed();

        const int MaxStackAllocLength = 512;
        if (title.Length > MaxStackAllocLength)
        {
            throw new ArgumentException("String is too long for stack allocation.");
        }

        var byteCount = Encoding.UTF8.GetByteCount(title);
        Span<byte> titleBytes = stackalloc byte[byteCount + 1];

        Encoding.UTF8.GetBytes(title, titleBytes.Slice(0, byteCount));
        titleBytes[byteCount] = 0; // Null-terminate

        var monitorValue = monitor ?? GlfwMonitor.None;
        var shareValue = share ?? GlfwWindow.None;

        fixed (byte* titlePtr = titleBytes)
        {
            return _commands.glfwCreateWindow(width, height, titlePtr, monitorValue, shareValue);
        }
    }

    public static void DestroyWindow(GlfwWindow window)
    {
        CheckDisposed();

        _commands.glfwDestroyWindow(window);
    }

    public static bool WindowShouldClose(GlfwWindow window)
    {
        CheckDisposed();

        return _commands.glfwWindowShouldClose(window);
    }

    public static void PollEvents()
    {
        CheckDisposed();

        _commands.glfwPollEvents();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void CheckDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(typeof(Glfw).FullName);
        }
    }

    
}

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
        var extensionsPtr = (nint*) _commands.glfwGetRequiredInstanceExtensions(&count);

        if (extensionsPtr == null || count == 0)
            return Array.Empty<string>();

        var extensions = new string[count];

        for (uint i = 0; i < count; i++)
        {
            extensions[i] = Marshal.PtrToStringUTF8(extensionsPtr[i])!;
        }

        return extensions;
    }
}


public delegate void ErrorCallback(int code, string message);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void GLFWerrorfun(int error, byte* description);

internal unsafe class GlfwVulkanCommands
{
    public delegate* unmanaged[Cdecl]<bool> glfwVulkanSupported;
    public delegate* unmanaged[Cdecl]<uint*, nint> glfwGetRequiredInstanceExtensions;

    public GlfwVulkanCommands(nint libraryHandle)
    {
        glfwVulkanSupported = (delegate* unmanaged[Cdecl]<bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwVulkanSupported");

        glfwGetRequiredInstanceExtensions = (delegate* unmanaged[Cdecl]<uint*, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetRequiredInstanceExtensions");

    }
}
internal unsafe class GlfwCommands
{
    public delegate* unmanaged[Cdecl]<nint, out float, out float, void> glfwGetMonitorContentScale;
    public delegate* unmanaged[Cdecl]<nint, nint> glfwGetMonitorUserPointer;
    public delegate* unmanaged[Cdecl]<nint, nint, void> glfwSetMonitorUserPointer;
    public delegate* unmanaged[Cdecl]<nint, float> glfwGetWindowOpacity;
    public delegate* unmanaged[Cdecl]<nint, float, void> glfwSetWindowOpacity;
    public delegate* unmanaged[Cdecl]<Hint, byte*, void> glfwWindowHintString;
    public delegate* unmanaged[Cdecl]<nint, out float, out float, void> glfwGetWindowContentScale;
    public delegate* unmanaged[Cdecl]<nint, void> glfwRequestWindowAttention;
    public delegate* unmanaged[Cdecl]<bool> glfwRawMouseMotionSupported;
    //public delegate* unmanaged[Cdecl]<nint, WindowMaximizedCallback, WindowMaximizedCallback> glfwSetWindowMaximizeCallback;
    //public delegate* unmanaged[Cdecl]<nint, WindowContentsScaleCallback, WindowContentsScaleCallback> glfwSetWindowContentScaleCallback;
    //public delegate* unmanaged[Cdecl]<Keys, int> glfwGetKeyScancode;
    //public delegate* unmanaged[Cdecl]<nint, WindowAttribute, bool, void> glfwSetWindowAttrib;
    public delegate* unmanaged[Cdecl]<int, int*, nint> glfwGetJoystickHats;
    public delegate* unmanaged[Cdecl]<int, nint> glfwGetJoystickGUID;
    public delegate* unmanaged[Cdecl]<int, nint> glfwGetJoystickUserPointer;
    public delegate* unmanaged[Cdecl]<int, nint, void> glfwSetJoystickUserPointer;
    public delegate* unmanaged[Cdecl]<int, bool> glfwJoystickIsGamepad;
    public delegate* unmanaged[Cdecl]<byte*, bool> glfwUpdateGamepadMappings;
    public delegate* unmanaged[Cdecl]<int, nint> glfwGetGamepadName;
    //public delegate* unmanaged[Cdecl]<int, GamePadState*, bool> glfwGetGamepadState;
    public delegate* unmanaged[Cdecl]<Hint, bool, void> glfwInitHint;
    public delegate* unmanaged[Cdecl]<bool> glfwInit;
    public delegate* unmanaged[Cdecl]<bool> glfwTerminate;
    public delegate* unmanaged[Cdecl]<nint, nint> glfwSetErrorCallback;
    public delegate* unmanaged[Cdecl]<int, int, byte*, GlfwMonitor, GlfwWindow, GlfwWindow> glfwCreateWindow;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwDestroyWindow;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwShowWindow;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwHideWindow;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int*, nint*, void> glfwGetWindowPos;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int, int, void> glfwSetWindowPos;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int*, int*, void> glfwGetWindowSize;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int, int, void> glfwSetWindowSize;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int*, int*, void> glfwGetFramebufferSize;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, PositionCallback, PositionCallback> glfwSetWindowPosCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, SizeCallback, SizeCallback> glfwSetWindowSizeCallback;
    public delegate* unmanaged[Cdecl]<GlfwWindow, byte*, void> glfwSetWindowTitle;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwFocusWindow;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, FocusCallback, FocusCallback> glfwSetWindowFocusCallback;
    public delegate* unmanaged[Cdecl]<int*, int*, int*, void> glfwGetVersion;
    public delegate* unmanaged[Cdecl]<nint> glfwGetVersionString;
    public delegate* unmanaged[Cdecl]<double> glfwGetTime;
    public delegate* unmanaged[Cdecl]<double, void> glfwSetTime;
    public delegate* unmanaged[Cdecl]<ulong> glfwGetTimerFrequency;
    public delegate* unmanaged[Cdecl]<ulong> glfwGetTimerValue;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int*, int*, int*, void> glfwGetWindowFrameSize;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwMaximizeWindow;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwIconifyWindow;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwRestoreWindow;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwMakeContextCurrent;
    public delegate* unmanaged[Cdecl]<GlfwWindow, void> glfwSwapBuffers;
    public delegate* unmanaged[Cdecl]<int, void> glfwSwapInterval;
    public delegate* unmanaged[Cdecl]<byte*, bool> glfwExtensionSupported;
    public delegate* unmanaged[Cdecl]<void> glfwDefaultWindowHints;
    public delegate* unmanaged[Cdecl]<GlfwWindow, bool> glfwWindowShouldClose;
    public delegate* unmanaged[Cdecl]<GlfwWindow, bool, void> glfwSetWindowShouldClose;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, int, Image*, void> glfwSetWindowIcon;
    public delegate* unmanaged[Cdecl]<void> glfwWaitEvents;
    public delegate* unmanaged[Cdecl]<void> glfwPollEvents;
    public delegate* unmanaged[Cdecl]<void> glfwPostEmptyEvent;
    public delegate* unmanaged[Cdecl]<double, void> glfwWaitEventsTimeout;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, WindowCallback, WindowCallback> glfwSetWindowCloseCallback;
    public delegate* unmanaged[Cdecl]<GlfwMonitor> glfwGetPrimaryMonitor;
    public delegate* unmanaged[Cdecl]<GlfwMonitor, nint> glfwGetVideoMode;
    public delegate* unmanaged[Cdecl]<GlfwMonitor, int*, nint> glfwGetVideoModes;
    public delegate* unmanaged[Cdecl]<GlfwWindow, GlfwMonitor> glfwGetWindowMonitor;
    public delegate* unmanaged[Cdecl]<GlfwWindow, GlfwMonitor, int, int, int, int, int, void> glfwSetWindowMonitor;
    public delegate* unmanaged[Cdecl]<GlfwMonitor, nint> glfwGetGammaRamp;
    //public delegate* unmanaged[Cdecl]<GlfwMonitor, GammaRamp, void> glfwSetGammaRamp;
    public delegate* unmanaged[Cdecl]<GlfwMonitor, float, void> glfwSetGamma;
    public delegate* unmanaged[Cdecl]<GlfwWindow, nint> glfwGetClipboardString;
    public delegate* unmanaged[Cdecl]<GlfwWindow, byte*, void> glfwSetClipboardString;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, FileDropCallback, FileDropCallback> glfwSetDropCallback;
    public delegate* unmanaged[Cdecl]<GlfwMonitor, nint> glfwGetMonitorName;
    //public delegate* unmanaged[Cdecl]<Image, int, int, Cursor> glfwCreateCursor;
    //public delegate* unmanaged[Cdecl]<Cursor, void> glfwDestroyCursor;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, Cursor, void> glfwSetCursor;
    //public delegate* unmanaged[Cdecl]<CursorType, Cursor> glfwCreateStandardCursor;
    public delegate* unmanaged[Cdecl]<GlfwWindow, double*, double*, void> glfwGetCursorPos;
    public delegate* unmanaged[Cdecl]<GlfwWindow, double, double, void> glfwSetCursorPos;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, MouseCallback, MouseCallback> glfwSetCursorPosCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, MouseEnterCallback, MouseEnterCallback> glfwSetCursorEnterCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, MouseButtonCallback, MouseButtonCallback> glfwSetMouseButtonCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, MouseCallback, MouseCallback> glfwSetScrollCallback;
    //public delegate* unmanaged[Cdecl]<InputState, Window, MouseButton> glfwGetMouseButton;
    public delegate* unmanaged[Cdecl]<GlfwWindow, nint, void> glfwSetWindowUserPointer;
    public delegate* unmanaged[Cdecl]<GlfwWindow, nint> glfwGetWindowUserPointer;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int, int, int, int, void> glfwSetWindowSizeLimits;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int, int, void> glfwSetWindowAspectRatio;
    public delegate* unmanaged[Cdecl]<GlfwWindow> glfwGetCurrentContext;
    public delegate* unmanaged[Cdecl]<GlfwMonitor, int*, int*, void> glfwGetMonitorPhysicalSize;
    public delegate* unmanaged[Cdecl]<GlfwMonitor, int*, int*, void> glfwGetMonitorPos;
    public delegate* unmanaged[Cdecl]<int*, nint> glfwGetMonitors;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, CharCallback, CharCallback> glfwSetCharCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, CharModsCallback, CharModsCallback> glfwSetCharModsCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, Keys, InputState> glfwGetKey;
    //public delegate* unmanaged[Cdecl]<Keys, int, nint> glfwGetKeyName;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, SizeCallback, SizeCallback> glfwSetFramebufferSizeCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, WindowCallback, WindowCallback> glfwSetWindowRefreshCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, KeyCallback, KeyCallback> glfwSetKeyCallback;
    //public delegate* unmanaged[Cdecl]<Joystick, bool> glfwJoystickPresent;
    //public delegate* unmanaged[Cdecl]<Joystick, nint> glfwGetJoystickName;
    //public delegate* unmanaged[Cdecl]<Joystick, int*, nint> glfwGetJoystickAxes;
    //public delegate* unmanaged[Cdecl]<Joystick, int*, nint> glfwGetJoystickButtons;
    //public delegate* unmanaged[Cdecl]<JoystickCallback, JoystickCallback> glfwSetJoystickCallback;
    //public delegate* unmanaged[Cdecl]<MonitorCallback, MonitorCallback> glfwSetMonitorCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, IconifyCallback, IconifyCallback> glfwSetWindowIconifyCallback;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, InputMode, int, void> glfwSetInputMode;
    //public delegate* unmanaged[Cdecl]<GlfwWindow, InputMode, void> glfwGetInputMode;
    public delegate* unmanaged[Cdecl]<IntPtr, int*, int*, int*, int*, void> glfwGetMonitorWorkarea;
    public delegate* unmanaged[Cdecl]<byte*, nint> glfwGetProcAddress;
    public delegate* unmanaged[Cdecl]<Hint, int, void> glfwWindowHint;
    public delegate* unmanaged[Cdecl]<GlfwWindow, int, int> glfwGetWindowAttrib;
    public delegate* unmanaged[Cdecl]<nint*, int> glfwGetError;

    public GlfwCommands(nint libraryHandle)
    {
        glfwGetMonitorContentScale = (delegate* unmanaged[Cdecl]<nint, out float, out float, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetMonitorContentScale");

        glfwGetMonitorUserPointer = (delegate* unmanaged[Cdecl]<nint, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetMonitorUserPointer");

        glfwSetMonitorUserPointer = (delegate* unmanaged[Cdecl]<nint, nint, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetMonitorUserPointer");

        glfwGetWindowOpacity = (delegate* unmanaged[Cdecl]<nint, float>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetWindowOpacity");

        glfwSetWindowOpacity = (delegate* unmanaged[Cdecl]<nint, float, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowOpacity");

        glfwWindowHintString = (delegate* unmanaged[Cdecl]<Hint, byte*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwWindowHintString");

        glfwGetWindowContentScale = (delegate* unmanaged[Cdecl]<nint, out float, out float, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetWindowContentScale");

        glfwRequestWindowAttention = (delegate* unmanaged[Cdecl]<nint, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwRequestWindowAttention");

        glfwRawMouseMotionSupported = (delegate* unmanaged[Cdecl]<bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwRawMouseMotionSupported");

        //glfwSetWindowMaximizeCallback = (delegate* unmanaged[Cdecl]<nint, WindowMaximizedCallback, WindowMaximizedCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowMaximizeCallback");

        //glfwSetWindowContentScaleCallback = (delegate* unmanaged[Cdecl]<nint, WindowContentsScaleCallback, WindowContentsScaleCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowContentScaleCallback");

        //glfwGetKeyScancode = (delegate* unmanaged[Cdecl]<Keys, int>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetKeyScancode");

        //glfwSetWindowAttrib = (delegate* unmanaged[Cdecl]<nint, WindowAttribute, bool, void>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowAttrib");

        glfwGetJoystickHats = (delegate* unmanaged[Cdecl]<int, int*, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetJoystickHats");

        glfwGetJoystickGUID = (delegate* unmanaged[Cdecl]<int, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetJoystickGUID");

        glfwGetJoystickUserPointer = (delegate* unmanaged[Cdecl]<int, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetJoystickUserPointer");

        glfwSetJoystickUserPointer = (delegate* unmanaged[Cdecl]<int, nint, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetJoystickUserPointer");

        glfwJoystickIsGamepad = (delegate* unmanaged[Cdecl]<int, bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwJoystickIsGamepad");

        glfwUpdateGamepadMappings = (delegate* unmanaged[Cdecl]<byte*, bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwUpdateGamepadMappings");

        glfwGetGamepadName = (delegate* unmanaged[Cdecl]<int, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetGamepadName");

        //glfwGetGamepadState = (delegate* unmanaged[Cdecl]<int, GamePadState*, bool>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetGamepadState");

        glfwInitHint = (delegate* unmanaged[Cdecl]<Hint, bool, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwInitHint");

        glfwInit = (delegate* unmanaged[Cdecl]<bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwInit");

        glfwTerminate = (delegate* unmanaged[Cdecl]<bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwTerminate");

        glfwSetErrorCallback = (delegate* unmanaged[Cdecl]<nint, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetErrorCallback");

        glfwCreateWindow = (delegate* unmanaged[Cdecl]<int, int, byte*, GlfwMonitor, GlfwWindow, GlfwWindow>)
            NativeLibrary.GetExport(libraryHandle, "glfwCreateWindow");

        glfwDestroyWindow = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwDestroyWindow");

        glfwShowWindow = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwShowWindow");

        glfwHideWindow = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwHideWindow");

        glfwGetWindowPos = (delegate* unmanaged[Cdecl]<GlfwWindow, int*, nint*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetWindowPos");

        glfwSetWindowPos = (delegate* unmanaged[Cdecl]<GlfwWindow, int, int, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowPos");

        glfwGetWindowSize = (delegate* unmanaged[Cdecl]<GlfwWindow, int*, int*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetWindowSize");

        glfwSetWindowSize = (delegate* unmanaged[Cdecl]<GlfwWindow, int, int, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowSize");

        glfwGetFramebufferSize = (delegate* unmanaged[Cdecl]<GlfwWindow, int*, int*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetFramebufferSize");

        //glfwSetWindowPosCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, PositionCallback, PositionCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowPosCallback");

        //glfwSetWindowSizeCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, SizeCallback, SizeCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowSizeCallback");

        glfwSetWindowTitle = (delegate* unmanaged[Cdecl]<GlfwWindow, byte*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowTitle");

        glfwFocusWindow = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwFocusWindow");

        //glfwSetWindowFocusCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, FocusCallback, FocusCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowFocusCallback");

        glfwGetVersion = (delegate* unmanaged[Cdecl]<int*, int*, int*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetVersion");

        glfwGetVersionString = (delegate* unmanaged[Cdecl]<nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetVersionString");

        glfwGetTime = (delegate* unmanaged[Cdecl]<double>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetTime");

        glfwSetTime = (delegate* unmanaged[Cdecl]<double, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetTime");

        glfwGetTimerFrequency = (delegate* unmanaged[Cdecl]<ulong>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetTimerFrequency");

        glfwGetTimerValue = (delegate* unmanaged[Cdecl]<ulong>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetTimerValue");

        glfwGetWindowFrameSize = (delegate* unmanaged[Cdecl]<GlfwWindow, int*, int*, int*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetWindowFrameSize");

        glfwMaximizeWindow = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwMaximizeWindow");

        glfwIconifyWindow = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwIconifyWindow");

        glfwRestoreWindow = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwRestoreWindow");

        glfwMakeContextCurrent = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwMakeContextCurrent");

        glfwSwapBuffers = (delegate* unmanaged[Cdecl]<GlfwWindow, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSwapBuffers");

        glfwSwapInterval = (delegate* unmanaged[Cdecl]<int, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSwapInterval");

        glfwExtensionSupported = (delegate* unmanaged[Cdecl]<byte*, bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwExtensionSupported");

        glfwDefaultWindowHints = (delegate* unmanaged[Cdecl]<void>)
            NativeLibrary.GetExport(libraryHandle, "glfwDefaultWindowHints");

        glfwWindowShouldClose = (delegate* unmanaged[Cdecl]<GlfwWindow, bool>)
            NativeLibrary.GetExport(libraryHandle, "glfwWindowShouldClose");

        glfwSetWindowShouldClose = (delegate* unmanaged[Cdecl]<GlfwWindow, bool, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowShouldClose");

        //glfwSetWindowIcon = (delegate* unmanaged[Cdecl]<GlfwWindow, int, Image*, void>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowIcon");

        glfwWaitEvents = (delegate* unmanaged[Cdecl]<void>)
            NativeLibrary.GetExport(libraryHandle, "glfwWaitEvents");

        glfwPollEvents = (delegate* unmanaged[Cdecl]<void>)
            NativeLibrary.GetExport(libraryHandle, "glfwPollEvents");

        glfwPostEmptyEvent = (delegate* unmanaged[Cdecl]<void>)
            NativeLibrary.GetExport(libraryHandle, "glfwPostEmptyEvent");

        glfwWaitEventsTimeout = (delegate* unmanaged[Cdecl]<double, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwWaitEventsTimeout");

        //glfwSetWindowCloseCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, WindowCallback, WindowCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowCloseCallback");

        glfwGetPrimaryMonitor = (delegate* unmanaged[Cdecl]<GlfwMonitor>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetPrimaryMonitor");

        glfwGetVideoMode = (delegate* unmanaged[Cdecl]<GlfwMonitor, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetVideoMode");

        glfwGetVideoModes = (delegate* unmanaged[Cdecl]<GlfwMonitor, int*, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetVideoModes");

        glfwGetWindowMonitor = (delegate* unmanaged[Cdecl]<GlfwWindow, GlfwMonitor>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetWindowMonitor");

        glfwSetWindowMonitor = (delegate* unmanaged[Cdecl]<GlfwWindow, GlfwMonitor, int, int, int, int, int, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowMonitor");

        glfwGetGammaRamp = (delegate* unmanaged[Cdecl]<GlfwMonitor, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetGammaRamp");

        //glfwSetGammaRamp = (delegate* unmanaged[Cdecl]<GlfwMonitor, GammaRamp, void>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetGammaRamp");

        glfwSetGamma = (delegate* unmanaged[Cdecl]<GlfwMonitor, float, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetGamma");

        glfwGetClipboardString = (delegate* unmanaged[Cdecl]<GlfwWindow, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetClipboardString");

        glfwSetClipboardString = (delegate* unmanaged[Cdecl]<GlfwWindow, byte*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetClipboardString");

        //glfwSetDropCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, FileDropCallback, FileDropCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetDropCallback");

        glfwGetMonitorName = (delegate* unmanaged[Cdecl]<GlfwMonitor, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetMonitorName");

        //glfwCreateCursor = (delegate* unmanaged[Cdecl]<Image, int, int, Cursor>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwCreateCursor");

        //glfwDestroyCursor = (delegate* unmanaged[Cdecl]<Cursor, void>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwDestroyCursor");

        //glfwSetCursor = (delegate* unmanaged[Cdecl]<GlfwWindow, Cursor, void>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetCursor");

        //glfwCreateStandardCursor = (delegate* unmanaged[Cdecl]<CursorType, Cursor>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwCreateStandardCursor");

        glfwGetCursorPos = (delegate* unmanaged[Cdecl]<GlfwWindow, double*, double*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetCursorPos");

        glfwSetCursorPos = (delegate* unmanaged[Cdecl]<GlfwWindow, double, double, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetCursorPos");

        //glfwSetCursorPosCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, MouseCallback, MouseCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetCursorPosCallback");

        //glfwSetCursorEnterCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, MouseEnterCallback, MouseEnterCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetCursorEnterCallback");

        //glfwSetMouseButtonCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, MouseButtonCallback, MouseButtonCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetMouseButtonCallback");

        //glfwSetScrollCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, MouseCallback, MouseCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetScrollCallback");

        //glfwGetMouseButton = (delegate* unmanaged[Cdecl]<InputState, GlfwWindow, MouseButton>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetMouseButton");

        glfwSetWindowUserPointer = (delegate* unmanaged[Cdecl]<GlfwWindow, nint, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowUserPointer");

        glfwGetWindowUserPointer = (delegate* unmanaged[Cdecl]<GlfwWindow, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetWindowUserPointer");

        glfwSetWindowSizeLimits = (delegate* unmanaged[Cdecl]<GlfwWindow, int, int, int, int, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowSizeLimits");

        glfwSetWindowAspectRatio = (delegate* unmanaged[Cdecl]<GlfwWindow, int, int, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwSetWindowAspectRatio");

        glfwGetCurrentContext = (delegate* unmanaged[Cdecl]<GlfwWindow>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetCurrentContext");

        glfwGetMonitorPhysicalSize = (delegate* unmanaged[Cdecl]<GlfwMonitor, int*, int*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetMonitorPhysicalSize");

        glfwGetMonitorPos = (delegate* unmanaged[Cdecl]<GlfwMonitor, int*, int*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetMonitorPos");

        glfwGetMonitors = (delegate* unmanaged[Cdecl]<int*, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetMonitors");

        //glfwSetCharCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, CharCallback, CharCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetCharCallback");

        //glfwSetCharModsCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, CharModsCallback, CharModsCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetCharModsCallback");

        //glfwGetKey = (delegate* unmanaged[Cdecl]<GlfwWindow, Keys, InputState>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetKey");

        //glfwGetKeyName = (delegate* unmanaged[Cdecl]<Keys, int, nint>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetKeyName");

        //glfwSetFramebufferSizeCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, SizeCallback, SizeCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetFramebufferSizeCallback");

        //glfwSetWindowRefreshCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, WindowCallback, WindowCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowRefreshCallback");

        //glfwSetKeyCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, KeyCallback, KeyCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetKeyCallback");

        //glfwJoystickPresent = (delegate* unmanaged[Cdecl]<Joystick, bool>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwJoystickPresent");

        //glfwGetJoystickName = (delegate* unmanaged[Cdecl]<Joystick, nint>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetJoystickName");

        //glfwGetJoystickAxes = (delegate* unmanaged[Cdecl]<Joystick, int*, nint>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetJoystickAxes");

        //glfwGetJoystickButtons = (delegate* unmanaged[Cdecl]<Joystick, int*, nint>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetJoystickButtons");

        //glfwSetJoystickCallback = (delegate* unmanaged[Cdecl]<JoystickCallback, JoystickCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetJoystickCallback");

        //glfwSetMonitorCallback = (delegate* unmanaged[Cdecl]<MonitorCallback, MonitorCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetMonitorCallback");

        //glfwSetWindowIconifyCallback = (delegate* unmanaged[Cdecl]<GlfwWindow, IconifyCallback, IconifyCallback>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetWindowIconifyCallback");

        //glfwSetInputMode = (delegate* unmanaged[Cdecl]<GlfwWindow, InputMode, int, void>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwSetInputMode");

        //glfwGetInputMode = (delegate* unmanaged[Cdecl]<GlfwWindow, InputMode, void>)
        //    NativeLibrary.GetExport(libraryHandle, "glfwGetInputMode");

        glfwGetMonitorWorkarea = (delegate* unmanaged[Cdecl]<IntPtr, int*, int*, int*, int*, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetMonitorWorkarea");

        glfwGetProcAddress = (delegate* unmanaged[Cdecl]<byte*, nint>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetProcAddress");

        glfwWindowHint = (delegate* unmanaged[Cdecl]<Hint, int, void>)
            NativeLibrary.GetExport(libraryHandle, "glfwWindowHint");

        glfwGetWindowAttrib = (delegate* unmanaged[Cdecl]<GlfwWindow, int, int>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetWindowAttrib");

        glfwGetError = (delegate* unmanaged[Cdecl]<nint*, int>)
            NativeLibrary.GetExport(libraryHandle, "glfwGetError");
    }
}


[StructLayout(LayoutKind.Sequential)]
public readonly struct GlfwMonitor : IEquatable<GlfwMonitor>
{
    public static readonly GlfwMonitor None;

    private readonly nint _handle;

    public GlfwMonitor(nint handle) => _handle = handle;

    public bool Equals(GlfwMonitor other) => _handle.Equals(other._handle);

    public override bool Equals(object? obj)
    {
        if (obj is GlfwMonitor monitor)
            return Equals(monitor);

        return false;
    }

    public override int GetHashCode() => _handle.GetHashCode();

    public static bool operator ==(GlfwMonitor left, GlfwMonitor right) => left.Equals(right);

    public static bool operator !=(GlfwMonitor left, GlfwMonitor right) => !left.Equals(right);

    public static implicit operator nint(GlfwMonitor window) => window._handle;

    public static explicit operator GlfwMonitor(nint handle) => new(handle);
}

[StructLayout(LayoutKind.Sequential)]
public readonly struct GlfwWindow : IEquatable<GlfwWindow>
{
    public static readonly GlfwWindow None;

    private readonly nint _handle;

    public GlfwWindow(nint handle) => _handle = handle;

    public override string ToString() => _handle.ToString();

    public bool Equals(GlfwWindow other) => _handle.Equals(other._handle);

    public override bool Equals(object? obj)
    {
        if (obj is GlfwWindow window)
            return Equals(window);

        return false;
    }

    public override int GetHashCode() => _handle.GetHashCode();

    public static bool operator ==(GlfwWindow left, GlfwWindow right) => left.Equals(right);

    public static bool operator !=(GlfwWindow left, GlfwWindow right) => !left.Equals(right);

    public static implicit operator nint(GlfwWindow window) => window._handle;

    public static explicit operator GlfwWindow(nint handle) => new(handle);
}

public enum Hint
{
    /// <summary>
    ///     Specifies whether the windowed mode window will be given input focus when created. This hint is ignored for full
    ///     screen and initially hidden windows.
    ///     <para>Default Value: <see cref="Constants.True" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    Focused = 0x00020001,

    /// <summary>
    ///     Specifies whether the windowed mode window will be resizable by the user. The window will still be resizable
    ///     programmatically. This hint is ignored for full screen windows.
    ///     <para>Default Value: <see cref="Constants.True" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    Resizable = 0x00020003,

    /// <summary>
    ///     Specifies whether the windowed mode window will be initially visible.This hint is ignored for full screen windows.
    ///     <para>Default Value: <see cref="Constants.True" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    Visible = 0x00020004,

    /// <summary>
    ///     Specifies whether the windowed mode window will have window decorations such as a border, a close widget, etc.An
    ///     undecorated window may still allow the user to generate close events on some platforms.This hint is ignored for
    ///     full screen windows.
    ///     <para>Default Value: <see cref="Constants.True" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    Decorated = 0x00020005,

    /// <summary>
    ///     Specifies whether the full screen window will automatically iconify and restore the previous video mode on input
    ///     focus loss. This hint is ignored for windowed mode windows.
    ///     <para>Default Value: <see cref="Constants.True" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    AutoIconify = 0x00020006,

    /// <summary>
    ///     Specifies whether the windowed mode window will be floating above other regular windows, also called topmost or
    ///     always-on-top.This is intended primarily for debugging purposes and cannot be used to implement proper full screen
    ///     windows. This hint is ignored for full screen windows.
    ///     <para>Default Value: <see cref="Constants.False" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    Floating = 0x00020007,

    /// <summary>
    ///     Specifies whether the windowed mode window will be maximized when created. This hint is ignored for full screen
    ///     windows.
    ///     <para>Default Value: <see cref="Constants.False" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    Maximized = 0x00020008,

    /// <summary>
    ///     Specifies the desired bit depth of the red component for default framebuffer. <see cref="Constants.Default" />
    ///     means
    ///     the application has no preference.
    ///     <para>Default Value: <c>8</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    RedBits = 0x00021001,

    /// <summary>
    ///     Specifies the desired bit depth of the green component for default framebuffer. <see cref="Constants.Default" />
    ///     means
    ///     the application has no preference.
    ///     <para>Default Value: <c>8</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    GreenBits = 0x00021002,

    /// <summary>
    ///     Specifies the desired bit depth of the blue component for default framebuffer. <see cref="Constants.Default" />
    ///     means
    ///     the application has no preference.
    ///     <para>Default Value: <c>8</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    BlueBits = 0x00021003,

    /// <summary>
    ///     Specifies the desired bit depth of the alpha component for default framebuffer. <see cref="Constants.Default" />
    ///     means
    ///     the application has no preference.
    ///     <para>Default Value: <c>8</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    AlphaBits = 0x00021004,

    /// <summary>
    ///     Specifies the desired bit depth of for default framebuffer. <see cref="Constants.Default" />"/> means the
    ///     application
    ///     has no preference.
    ///     <para>Default Value: <c>24</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    DepthBits = 0x00021005,

    /// <summary>
    ///     Specifies the desired stencil bits for default framebuffer. <see cref="Constants.Default" /> means the application
    ///     has
    ///     no preference.
    ///     <para>Default Value: <c>0</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    StencilBits = 0x00021006,

    /// <summary>
    ///     Specify the desired bit depths of the red component of the accumulation buffer. <see cref="Constants.Default" />
    ///     means
    ///     the application has no preference.
    ///     <para>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</para>
    ///     <para>Default Value: <c>0</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    [Obsolete]
    AccumRedBits = 0x00021007,

    /// <summary>
    ///     Specify the desired bit depths of the green component of the accumulation buffer. <see cref="Constants.Default" />
    ///     means the application has no preference.
    ///     <para>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</para>
    ///     <para>Default Value: <c>0</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    [Obsolete]
    AccumGreenBits = 0x00021008,

    /// <summary>
    ///     Specify the desired bit depths of the blue component of the accumulation buffer. <see cref="Constants.Default" />
    ///     means the application has no preference.
    ///     <para>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</para>
    ///     <para>Default Value: <c>0</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    [Obsolete]
    AccumBlueBits = 0x00021009,

    /// <summary>
    ///     Specify the desired bit depths of the alpha component of the accumulation buffer.
    ///     <para><see cref="Constants.Default" /> means the application has no preference.</para>
    ///     <para>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</para>
    ///     <para>Default Value: <c>0</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    [Obsolete]
    AccumAlphaBits = 0x0002100a,

    /// <summary>
    ///     Specifies the desired number of auxiliary buffers.<see cref="Constants.Default" /> means the application has no
    ///     preference.
    ///     <para>Auxiliary buffers are a legacy OpenGL feature and should not be used in new code.</para>
    ///     <para>Default Value: <c>0</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    [Obsolete]
    AuxBuffers = 0x0002100b,

    /// <summary>
    ///     Specifies whether to use stereoscopic rendering.
    ///     <para>This is a hard constraint.</para>
    ///     <para>Default Value: <see cref="Constants.False" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    Stereo = 0x0002100c,

    /// <summary>
    ///     Specifies the desired number of samples to use for multisampling.Zero disables multisampling.
    ///     <para><see cref="Constants.Default" /> means the application has no preference.</para>
    ///     <para>Default Value: <c>0</c></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    Samples = 0x0002100d,

    /// <summary>
    ///     Specifies whether the framebuffer should be sRGB capable. If supported, a created OpenGL context will support the
    ///     GL_FRAMEBUFFER_SRGB enable, also called GL_FRAMEBUFFER_SRGB_EXT) for controlling sRGB rendering and a created
    ///     OpenGL ES context will always have sRGB rendering enabled.
    ///     <para>Default Value: <see cref="Constants.False" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    SrgbCapable = 0x0002100e,

    /// <summary>
    ///     Specifies whether the framebuffer should be double buffered.You nearly always want to use double buffering.
    ///     <para>This is a hard constraint.</para>
    ///     <para>Default Value: <see cref="Constants.True" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    Doublebuffer = 0x00021010,

    /// <summary>
    ///     Specifies the desired refresh rate for full screen windows.
    ///     <para>If set to <see cref="Constants.Default" />, the highest available refresh rate will be used.</para>
    ///     <para>This hint is ignored for windowed mode windows.</para>
    ///     <para>Default Value: <see cref="Constants.Default" /></para>
    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
    /// </summary>
    RefreshRate = 0x0002100f,

    /// <summary>
    ///     Specifies which client API to create the context for.
    ///     <para>This is a hard constraint.</para>
    ///     <para>Default Value: <see cref="GLFW.ClientApi.OpenGL" /></para>
    ///     <para>Possible Values: Any of <see cref="GLFW.ClientApi" /> values.</para>
    /// </summary>
    ClientApi = 0x00022001,

    /// <summary>
    ///     Specifies which context creation API to use to create the context.
    ///     <para>If no client API is requested, this hint is ignored.</para>
    ///     <para>This is a hard constraint. </para>
    ///     <para>Default Value: <see cref="ContextApi.Native" /></para>
    ///     <para>Possible Values: Any of <see cref="ContextApi" /> values.</para>
    /// </summary>
    ContextCreationApi = 0x0002200b,

    /// <summary>
    ///     Specify the client API major version that the created context must be compatible with.
    ///     <para>The exact behavior of this hint depends on the requested client API, see remarks for details.</para>
    ///     <para>Default Value: <c>1</c></para>
    ///     <para>Possible Values: Any valid major version of the chosen client API</para>
    /// </summary>
    ContextVersionMajor = 0x00022002,

    /// <summary>
    ///     Specify the client API minor version that the created context must be compatible with.
    ///     <para>The exact behavior of this hint depends on the requested client API, see remarks for details.</para>
    ///     <para>Default Value: <c>0</c></para>
    ///     <para>Possible Values: Any valid minor version of the chosen client API</para>
    /// </summary>
    ContextVersionMinor = 0x00022003,

    /// <summary>
    ///     Specifies the robustness strategy to be used by the context.
    ///     <para>Default Value: <see cref="Robustness.None" /></para>
    ///     <para>Possible Values: Any of <see cref="Robustness" /> values</para>
    /// </summary>
    ContextRobustness = 0x00022005,

    /// <summary>
    ///     Specifies whether the OpenGL context should be forward-compatible, i.e. one where all functionality deprecated in
    ///     the requested version of OpenGL is removed.
    ///     <para>This must only be used if the requested OpenGL version is 3.0 or above.</para>
    ///     <para>If OpenGL ES is requested, this hint is ignored</para>
    ///     <para>Forward-compatibility is described in detail in the OpenGL Reference Manual.</para>
    ///     <para>Default Value: <see cref="Constants.False" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    OpenglForwardCompatible = 0x00022006,

    /// <summary>
    ///     Specifies whether to create a debug OpenGL context, which may have additional error and performance issue reporting
    ///     functionality.
    ///     <para>If OpenGL ES is requested, this hint is ignored.</para>
    ///     <para>Default Value: <see cref="Constants.False" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    OpenglDebugContext = 0x00022007,

    /// <summary>
    ///     Specifies which OpenGL profile to create the context for.
    ///     <para>If requesting an OpenGL version below <c>3.2</c>, <see cref="Profile.Any" />  must be used.</para>
    ///     <para>If OpenGL ES is requested, this hint is ignored.</para>
    ///     <para>OpenGL profiles are described in detail in the OpenGL Reference Manual.</para>
    ///     <para>Default Value: <see cref="Profile.Any" /></para>
    ///     <para>Possible Values: Any of <see cref="Profile" /> values</para>
    /// </summary>
    OpenglProfile = 0x00022008,

    /// <summary>
    ///     Specifies the release behavior to be used by the context.
    ///     <para>Default Value: <see cref="ReleaseBehavior.Any" /></para>
    ///     <para>Possible Values: Any of <see cref="ReleaseBehavior" /> values</para>
    /// </summary>
    ContextReleaseBehavior = 0x00022009,

    /// <summary>
    ///     Specifies whether errors should be generated by the context. If enabled, situations that would have generated
    ///     errors instead cause undefined behavior.
    ///     <para>Default Value: <see cref="Constants.False" /></para>
    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
    /// </summary>
    ContextNoError = 0x0002200a,

    /// <summary>
    ///     Specifies whether to also expose joystick hats as buttons, for compatibility with earlier versions of
    ///     GLFW (less than 3.3) that did not have <see cref="Glfw.GetJoystickHats(int)" />.
    /// </summary>
    JoystickHatButtons = 0x00050001,

    /// <summary>
    ///     Specifies whether to set the current directory to the application to the Contents/Resources
    ///     subdirectory of the application's bundle, if present.
    ///     <para>macOS ONLY!</para>
    /// </summary>
    CocoaChDirResources = 0x00051001,

    /// <summary>
    ///     Specifies whether to create a basic menu bar, either from a nib or manually, when the first window is
    ///     created, which is when AppKit is initialized.
    ///     <para>macOS ONLY!</para>
    /// </summary>
    CocoaMenuBar = 0x00051002,

    /// <summary>
    ///     Specifies whether the cursor should be centered over newly created full screen windows.
    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
    ///     <para>This hint is ignored for windowed mode windows.</para>
    /// </summary>
    CenterCursor = 0x00020009,

    /// <summary>
    ///     Specifies whether the window framebuffer will be transparent.
    ///     <para>
    ///         If enabled and supported by the system, the window framebuffer alpha channel will be used to combine
    ///         the framebuffer with the background. This does not affect window decorations.
    ///     </para>
    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
    /// </summary>
    TransparentFramebuffer = 0x0002000A,

    /// <summary>
    ///     Specifies whether the window will be given input focus when <see cref="Glfw.ShowWindow" /> is called.
    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
    /// </summary>
    FocusOnShow = 0x0002000C,

    /// <summary>
    ///     Specifies whether the window content area should be resized based on the monitor content scale of any
    ///     monitor it is placed on. This includes the initial placement when the window is created.
    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
    ///     <para>
    ///         This hint only has an effect on platforms where screen coordinates and pixels always map 1:1 such as
    ///         Windows and X11. On platforms like macOS the resolution of the framebuffer is changed independently
    ///         of the window size.
    ///     </para>
    /// </summary>
    ScaleToMonitor = 0x0002200C,

    /// <summary>
    ///     Specifies whether to use full resolution framebuffers on Retina displays.
    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
    ///     <para>This is ignored on other platforms.</para>
    /// </summary>
    CocoaRetinaFrameBuffer = 0x00023001,

    /// <summary>
    ///     Specifies the UTF-8 encoded name to use for auto-saving the window frame, or if empty disables frame
    ///     auto-saving for the window.
    ///     <para>macOs only, this is ignored on other platforms.</para>
    ///     <para>This is set with <see cref="Glfw.WindowHintString" />.</para>
    /// </summary>
    CocoaFrameName = 0x00023002,

    /// <summary>
    ///     Specifies whether to in Automatic Graphics Switching, i.e. to allow the system to choose the integrated
    ///     GPU for the OpenGL context and move it between GPUs if necessary or whether to force it to always run on
    ///     the discrete GPU.
    ///     <para>This only affects systems with both integrated and discrete GPUs, ignored on other platforms.</para>
    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
    /// </summary>
    CocoaGraphicsSwitching = 0x00023003,

    /// <summary>
    ///     Specifies the desired ASCII encoded class parts of the ICCCM <c>WM_CLASS</c> window property.
    ///     <para>Set with <see cref="Glfw.WindowHintString" />.</para>
    /// </summary>
    X11ClassName = 0x00024001,

    /// <summary>
    ///     Specifies the desired ASCII encoded instance parts of the ICCCM <c>WM_CLASS</c> window property.
    ///     <para>Set with <see cref="Glfw.WindowHintString" />.</para>
    /// </summary>
    X11InstanceName = 0x00024002
}
