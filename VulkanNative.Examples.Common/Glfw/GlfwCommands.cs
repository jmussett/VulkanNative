using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Glfw;

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
    public delegate* unmanaged[Cdecl]<nint, int*, int*, int*, int*, void> glfwGetMonitorWorkarea;
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

        glfwGetMonitorWorkarea = (delegate* unmanaged[Cdecl]<nint, int*, int*, int*, int*, void>)
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
