using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSRTDataNV
{
    public float sx;
    public float a;
    public float b;
    public float pvx;
    public float sy;
    public float c;
    public float pvy;
    public float sz;
    public float pvz;
    public float qx;
    public float qy;
    public float qz;
    public float qw;
    public float tx;
    public float ty;
    public float tz;
}