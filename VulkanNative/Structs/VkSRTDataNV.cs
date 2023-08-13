using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSRTDataNV
{
    public float Sx;
    public float A;
    public float B;
    public float Pvx;
    public float Sy;
    public float C;
    public float Pvy;
    public float Sz;
    public float Pvz;
    public float Qx;
    public float Qy;
    public float Qz;
    public float Qw;
    public float Tx;
    public float Ty;
    public float Tz;
}