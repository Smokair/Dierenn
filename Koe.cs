using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Koe : Dier
    {
        public SoundPlayer KoeStereo;

        public Koe(int gewicht) : base(gewicht)
        {
        }

        public  string boet()
        {
            KoeStereo = new SoundPlayer(@"C:\Users\PC\source\repos\Opdracht2.0\bin\Debug\net6.0-windows\cow.wav");
            KoeStereo.Play();
            return base.Zegt("Meuh");
        }

        public override string? ToString()
        {
            return boet();
        }

        
    }
}
