using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common.Glfw;

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
