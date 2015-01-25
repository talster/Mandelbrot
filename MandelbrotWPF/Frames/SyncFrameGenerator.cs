using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using MandelbrotWPF.Interfaces;

namespace MandelbrotWPF.Frames
{
    public class SyncFrameGenerator : ISyncFrameGenerator, IFrameGeneratorStatistics
    {
        /// <summary>
        /// Initialize the Frame Generator
        /// </summary>
        /// <param name="pixelColorGenerators">a list of Pixel Color generators</param>
        /// <returns>True if initialization succeeded. False otherwise</returns>
        public bool Init(List<IPixelColorGenerator> pixelColorGenerators)
        {
            if (pixelColorGenerators.Count == 0)
                return false;

            return true;
        }

        /// <summary>
        /// Generate a frame spanning from [xLeft ... xRight] and [yBottom..yTop] 
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
        public BitmapImage GenerateFrame(   double xLeft,   double xRight,  int columns,
                                            double yBottom, double yTop,    int rows)
        {
            return new BitmapImage();
        }

        /// <summary>
        /// Return statistics wrt the Frame Generator operation
        /// </summary>
        /// <returns>FrameGeneratorStat class containing various statistics</returns>
        public FrameGeneratorStat GetStatistics()
        {
            return new FrameGeneratorStat();
        }
    }
}
