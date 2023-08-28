using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Glfw;

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
