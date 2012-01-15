using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;

namespace mangaDbEditor.Classes.Utilities
{
    class Image
    {
        ///// <summary>
        ///// Image to byte array convertion. The function gets an Image and converts it to a byte array which it returns.
        ///// </summary>
        ///// <param name="myImage">My image.</param>
        ///// <returns></returns>
        //private static byte[] ImageToByteArray(Image myImage)
        //{
        //    //using (var ms = new MemoryStream())
        //    //{
        //    //    myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //    //    return ms.ToArray();
        //    //}
        //}

        ///// <summary>
        ///// Inserts an image to the database entry with the specified MangaTitle.
        ///// </summary>
        ///// <param name="imageByteArray">The image byte array.</param>
        //public void ImageToDatabaseLoader(byte[] imageByteArray)
        //{
        //    //var binaryFile = new System.Data.Linq.Binary(imageByteArray);
        //    //var mangaCoverImage = (from image in db.M_mangaInfo
        //    //                              where image.MangaID == Convert.ToInt16(mangaIdTextBox.Text)
        //    //                              select image).Single();
        //    //mangaCoverImage.MangaCover = binaryFile;
        //    //db.SubmitChanges();
        //}

        ///// <summary>
        ///// Get an Image in whatever Resolution and converts it to the closest to 160w*230h.
        ///// </summary>
        ///// <param name="sourceImage">The source image.</param>
        ///// <returns>The resized Image</returns>
        //private static Image ImageSizeToStandard(Image sourceImage)
        //{
        //    //var sourceWidth = sourceImage.Width;
        //    //var sourceHeight = sourceImage.Height;

        //    //var nPercentW = (160 / (float)sourceWidth);
        //    //var nPercentH = (230 / (float)sourceHeight);

        //    //var nPercent = nPercentH < nPercentW ? nPercentH : nPercentW;

        //    //var destWidth = (int)(sourceWidth * nPercent);
        //    //var destHeight = (int)(sourceHeight * nPercent);

        //    //using (var bmp = new Bitmap(destWidth, destHeight))
        //    //{
        //    //    var graph = Graphics.FromImage(bmp);
        //    //    graph.InterpolationMode = InterpolationMode.HighQualityBicubic;

        //    //    graph.DrawImage(sourceImage, 0, 0, destWidth, destHeight);
        //    //    graph.Dispose();

        //    //    return bmp;
        //    //}
        //}
    }
}
