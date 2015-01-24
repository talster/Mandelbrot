using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MandelbrotWPF
{
    public class SimplePictureGenerator : IPictureGenerator
    {
        /// <summary>
        /// Initialize the Picture Generator
        /// </summary>
        /// <param name="pixelGenerators">a list of Pixel generators</param>
        /// <returns>True if initialization succeeded. False otherwise</returns>
        public bool Init(List<IPixelGenerator> pixelGenerators)
        {
            if (pixelGenerators.Count == 0)
                return false;
            return true;
        }

        /// <summary>
        /// Generate an image spanning from [xLeft ... xRight] and [yBottom..yTop] 
        /// with the specified number of rows and columns
        /// </summary>
        /// <param name="xLeft">The smallest X coordinate of the generated image</param>
        /// <param name="xRight">The largest X coordinate of the generated image</param>
        /// <param name="columns">The number of columns in the image (spanning from xLeft to xRight)</param>
        /// <param name="yBottom">The smallest Y coordinate of the generated image</param>
        /// <param name="yTop">The largest Y coordinate of the generated image</param>
        /// <param name="rows">The number of rows in the image (spanning from yBottom to xTop)</param>
        /// <returns>An image with rows x columns pixels. 
        /// The X coordinates of all pixels span from xLeft to xRight.
        /// The Y coordinates of all pixels span from yBottom to yTop</returns>
        public BitmapImage GenerateImage(   double xLeft,   double xRight,  int columns,
                                            double yBottom, double yTop,    int rows)
        {
            return new BitmapImage();
        }
    }
}
