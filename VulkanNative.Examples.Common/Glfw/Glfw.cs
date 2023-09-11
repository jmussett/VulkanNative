using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace VulkanNative.Examples.Common.Glfw;

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
        var message = Marshal.PtrToStringUTF8((nint)messagePtr)!;

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

        Encoding.UTF8.GetBytes(title, titleBytes[..byteCount]);
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

    public static void WaitEvents()
    {
        CheckDisposed();

        _commands.glfwWaitEvents();
    }

    public static void GetFrameBufferSize(GlfwWindow window, out int width, out int height)
    {
        CheckDisposed();

        fixed (int* widthPtr = &width)
        fixed (int* heightPtr = &height)
            _commands.glfwGetFramebufferSize(window, widthPtr, heightPtr);
    }

    public static void SetWindowSizeCallback(GlfwWindow window, SizeCallback sizeCallback)
    {
        CheckDisposed();

        _commands.glfwSetWindowSizeCallback(window, sizeCallback);
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
