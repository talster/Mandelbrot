using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandelbrotWPF.Interfaces
{
    public class PixelGeneratorStat
    {
        public int      NumPixelGenerated   { get; set; }
        public double   AvgGenerationTime   { get; set; }
    }
}
