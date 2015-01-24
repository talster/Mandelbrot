using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandelbrotWPF
{
    public class MandelbrotPixelGenerator : IPixelGenerator
    {
        /// <summary>
        /// Returns the HTML Color for a given pixel of the Mandelbrot set
        /// </summary>
        /// <param name="x">X coordinates</param>
        /// <param name="y">Y coordinates</param>
        /// <returns>The HTML Color of the given pixel
        /// See http://html-color-codes.info/ for examples (e.g., "#FF0000" is red)
        /// </returns>
        public string GetPixelColor(double x, double y)
        {
            return "#FF0000";
        }
    }
}
