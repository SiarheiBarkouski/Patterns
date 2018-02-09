using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesFactory
{
    public class AudioFileInfo
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public double FileSize { get; set; }
    }
}
