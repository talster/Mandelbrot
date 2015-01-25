using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandelbrotWPF.Interfaces
{
    public interface IPixelGenerator
    {
        /// <summary>
        /// Returns a value for a specified pixel (x,y)
        /// </summary>
        /// <param name="x">X coordinates</param>
        /// <param name="y">Y coordinates</param>
        /// <returns>The value of the specified pixel (x,y)</returns>
        string GetPixelValue(double x, double y);
    }
}
