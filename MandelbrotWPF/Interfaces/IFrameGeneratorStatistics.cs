using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandelbrotWPF.Interfaces
{
    public interface IFrameGeneratorStatistics
    {
        /// <summary>
        /// Return statistics wrt the Frame Generator operation
        /// </summary>
        /// <returns>FrameGeneratorStat class containing various statistics</returns>
        FrameGeneratorStat GetStatistics();
    }
}
