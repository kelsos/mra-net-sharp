
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace mangaDbEditor.Classes.Utilities
{
    internal class ImageUtil
    {
        /// <summary>
        /// Image to byte array convertion. The function gets an Image and converts it to a byte array which it returns.
        /// </summary>
        /// <param name="myImage">My image.</param>
        /// <returns></returns>
        private static byte[] ToByteArray(Image myImage)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        ///// <summary>
        ///// Get an Image in whatever Resolution and converts it to the closest to 160w*230h.
        ///// </summary>
        ///// <param name="src">The source image.</param>
        ///// <returns>The resized Image</returns>
        public static byte[] Resize(Image src)
        {
            var sourceWidth = src.Width;
            var sourceHeight = src.Height;

            var nPercentW = (160 / (float)sourceWidth);
            var nPercentH = (230 / (float)sourceHeight);

            var nPercent = nPercentH < nPercentW ? nPercentW : nPercentH;

            var destWidth = (int)(sourceWidth * nPercent);
            var destHeight = (int)(sourceHeight * nPercent);
            byte[] imageData;
            using (Bitmap bmp = new Bitmap(destWidth, destHeight))
            {
                Graphics graph = Graphics.FromImage(bmp);
                graph.InterpolationMode = InterpolationMode.HighQualityBicubic;

                graph.DrawImage(src, 0, 0, destWidth, destHeight);
                graph.Dispose();
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                    bmp.Dispose();
                    imageData = ms.ToArray();
                    ms.Close();
                }
            }
            return imageData;
        }
    }
}
