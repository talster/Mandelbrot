using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandelbrotWPF.Interfaces;

namespace MandelbrotWPF.Mandelbrot
{
    public class MandelbrotPixelColorGenerator : IPixelColorGenerator
    {
        /// <summary>
        /// Initialize the Pixel Color Generator
        /// </summary>
        /// <param name="pixelGenerator">a Pixel generators</param>
        /// <returns>True if initialization succeeded. False otherwise</returns>
        public bool Init(IPixelGenerator pixelGenerator)
        {
            return true;
        }

        /// <summary>
        /// Returns the HTML Color for a given pixel 
        /// </summary>
        /// <param name="x">X coordinates</param>
        /// <param name="y">Y coordinates</param>
        /// <param name="pixelValue">The value of the specified pixel</param>
        /// <returns>The HTML Color of the specified pixel
        /// See http://html-color-codes.info/ for examples (e.g., "#FF0000" is red)
        /// </returns>
        public string GetPixelColor(double x, double y, string pixelValue)
        {
            return "#FF0000";
        }
    }
}
