using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Slang : Dier
    {
        public SoundPlayer SlangStereo;
        public Slang(int gewicht) : base(gewicht)
        {
        }

        public string ssst()
        {

            new SoundPlayer(@"C:\Users\PC\source\repos\Opdracht2.0\bin\Debug\net6.0-windows\snake.wav");
            SlangStereo.Play();
            return base.Zegt("Sss");
        }

        public override string? ToString()
        {
            return ssst();
        }
    }
}
