using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Varken : Dier
    {
        public SoundPlayer VarkensoundPlayer;
        public Varken(int gewicht) : base(gewicht)
        {
        }
        public string Oeink()
        {
            VarkensoundPlayer = new SoundPlayer(@"C:\Users\PC\source\repos\Opdracht2.0\bin\Debug\net6.0-windows\pig.wav");
            VarkensoundPlayer.Play();
            return base.Zegt("Oink");
        }

        public override string? ToString()
        {
            return Oeink();
        }
    }
}
