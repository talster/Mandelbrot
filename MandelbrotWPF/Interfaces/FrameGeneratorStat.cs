using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandelbrotWPF.Interfaces
{
    public class FrameGeneratorStat
    {
        public int      NumFramesGenerated { get; set; }
        public double   FPS                { get; set; }
    }
}
