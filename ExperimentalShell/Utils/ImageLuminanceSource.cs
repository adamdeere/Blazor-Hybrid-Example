namespace ExperimentalShell.Utils;

using Microsoft.Maui.Graphics.Platform;
using ZXing;
public class ImageLuminanceSource : RGBLuminanceSource
{
    public ImageLuminanceSource(PlatformImage image)
        : this((int)image.Width, (int)image.Height)
    {
        byte[]? rgbRawBytes = null;
#if ANDROID
        var pixels = new int[(int)image.Width * (int)image.Height];
        image.PlatformRepresentation.GetPixels(pixels, 0, (int)image.Width, 0, 0, (int)image.Width, (int)image.Height);
        rgbRawBytes = new byte[pixels.Length * 4];
        Buffer.BlockCopy(pixels, 0, rgbRawBytes, 0, rgbRawBytes.Length);

#endif
        CalculateLuminance(rgbRawBytes, BitmapFormat.RGB32);
    }
    protected ImageLuminanceSource(int width, int height)
        : base(width, height)
    {
    }
    protected override LuminanceSource CreateLuminanceSource(byte[] newLuminances, int width, int height)
    {
        return new ImageLuminanceSource(width, height) { luminances = newLuminances };
    }
}
