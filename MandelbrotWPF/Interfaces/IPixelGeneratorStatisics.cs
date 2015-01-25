using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandelbrotWPF.Interfaces
{
    public interface IPixelGeneratorStatisics
    {
        /// <summary>
        /// Return statistics wrt the Pixel Generator operation
        /// </summary>
        /// <returns>PixelGeneratorStat class containing various statistics</returns>
        PixelGeneratorStat GetStatistics(); 
    }
}
