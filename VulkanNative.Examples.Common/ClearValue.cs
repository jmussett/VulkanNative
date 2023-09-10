using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct ClearValue
{
    private readonly VkClearValue _handle;

    internal readonly VkClearValue Handle => _handle;

    public ClearValue(float r, float g, float b, float a)
    {
        _handle = new VkClearValue();

        _handle.color.float32[0] = r;
        _handle.color.float32[1] = g;
        _handle.color.float32[2] = b;
        _handle.color.float32[3] = a;
    }

    public ClearValue(int r, int g, int b, int a)
    {
        _handle = new VkClearValue();

        _handle.color.int32[0] = r;
        _handle.color.int32[1] = g;
        _handle.color.int32[2] = b;
        _handle.color.int32[3] = a;
    }

    public ClearValue(uint r, uint g, uint b, uint a)
    {
        _handle = new VkClearValue();

        _handle.color.uint32[0] = r;
        _handle.color.uint32[1] = g;
        _handle.color.uint32[2] = b;
        _handle.color.uint32[3] = a;
    }

    public ClearValue(float depth, uint stencil)
    {
        _handle = new VkClearValue
        {
            depthStencil = new VkClearDepthStencilValue
            {
                depth = depth,
                stencil = stencil
            }
        };
    }

    public static ClearValue ClearColor(float r, float g, float b, float a) => new (r, g, b, a);
    public static ClearValue ClearColor(int r, int g, int b, int a) => new(r, g, b, a);
    public static ClearValue ClearColor(uint r, uint g, uint b, uint a) => new(r, g, b, a);
    public static ClearValue ClearDepthStencil(float depth, uint stencil) => new(depth, stencil);
}