using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Dieren;

namespace Dieren2
{
    public partial class Form1 : Form
    {

        /*public SoundPlayer KoeStereo;*/
        /*public SoundPlayer SlangStereo;*/
        /*public SoundPlayer VarkenStereo;*/
        public Form1()
        {
            InitializeComponent();
            /*KoeStereo = new SoundPlayer(@"C:\Users\PC\source\repos\Dieren2\bin\Debug\net6.0-windows\meuglement.wav");*/
            /*SlangStereo = new SoundPlayer("SIFFLEMENT.wav");*/
            /*VarkenStereo = new SoundPlayer("grouinement.wav");*/
        }

        private void btHoren_Click(object sender, EventArgs e)
        {
            Dier koe = new Koe(1000);
            Dier varken= new Varken(250);
            Dier slang = new Slang(5);

            if(cbKoe.Checked)
            {
                MessageBox.Show(koe.ToString());
               /* KoeStereo.Play();*/
            }
            if (cbSlang.Checked)
            {
                MessageBox.Show(slang.ToString());
                /*SlangStereo.Play();*/
            }
            
            if(cbVarken.Checked)
            {
                MessageBox.Show(varken.ToString());
                /*VarkenStereo.Play();*/
            }
        }
    }
}
