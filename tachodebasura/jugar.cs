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

namespace tachodebasura
{
    public partial class jugar : Form
    {
        private int girarpapel;
      
        public jugar()
        {
            InitializeComponent();
            girarpapel = 0;
            lblpapel.Top = 120;
            lbltacho.Top = 120;
           
            //SoundPlayer intro = new SoundPlayer();
            //intro.Stream = Properties.Resources.;
            //intro.Play();
        }

        private void lblpapel_MouseClick(object sender, MouseEventArgs e)
        {   
           
            for (int ganar = 0; ganar < 35; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;

                this.Refresh();

            }
            this.Close();
            Form ganaste = new ganaste();
            ganaste.Show();
            SoundPlayer ganar1 = new SoundPlayer();
            ganar1.Stream = Properties.Resources.ganar;
            ganar1.Play();
           
        }



        private void button1_Click(object sender, EventArgs e)
        {


            for (int ganar = 0; ganar < 15; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;
                
                this.Refresh();

            }
            this.Close();
            Form perdiste = new perdiste();
            perdiste.Show();

            SoundPlayer disparo = new SoundPlayer();
            disparo.Stream = Properties.Resources.perder;
            disparo.Play();
            

        }

        private void bt2_Click(object sender, EventArgs e)
        {
           
            for (int ganar = 0; ganar < 60; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;

                this.Refresh();

            }
            this.Close();
            Form perdiste = new perdiste();
            perdiste.Show();
            SoundPlayer disparo = new SoundPlayer();
            disparo.Stream = Properties.Resources.perder;
            disparo.Play();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
           
            for (int ganar = 0; ganar < 20; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;

                this.Refresh();

            }
            this.Close();
            Form perdiste = new perdiste();
            perdiste.Show();
            SoundPlayer disparo = new SoundPlayer();
            disparo.Stream = Properties.Resources.perder;
            disparo.Play();


        }

        private void bt4_Click(object sender, EventArgs e)
        {
            
            for (int ganar = 0; ganar < 30; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;

                this.Refresh();

            }
            this.Close();
            Form perdiste = new perdiste();
            perdiste.Show();

            SoundPlayer disparo = new SoundPlayer();
            disparo.Stream = Properties.Resources.perder;
            disparo.Play();

        }

        private void bt5_Click(object sender, EventArgs e)
        {
          
            for (int ganar = 0; ganar < 10; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;

                this.Refresh();

            }
            this.Close();
            Form perdiste = new perdiste();
            perdiste.Show();
            SoundPlayer disparo = new SoundPlayer();
            disparo.Stream = Properties.Resources.perder;
            disparo.Play();


        }

        private void bt6_Click(object sender, EventArgs e)
        {
            
            for (int ganar = 0; ganar < 25; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;

                this.Refresh();

            }
            this.Close();
            Form perdiste = new perdiste();
            perdiste.Show();
            SoundPlayer disparo = new SoundPlayer();
            disparo.Stream = Properties.Resources.perder;
            disparo.Play();


        }

        private void bt7_Click(object sender, EventArgs e)
        {
           
            for (int ganar = 0; ganar < 15; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;

                this.Refresh();

            }
            this.Close();
            Form perdiste = new perdiste();
            perdiste.Show();

            SoundPlayer disparo = new SoundPlayer();
            disparo.Stream = Properties.Resources.perder;
            disparo.Play();

        }

        private void bt8_Click(object sender, EventArgs e)
        {
           
            for (int ganar = 0; ganar < 40; ganar++)
            {

                lblpapel.Left = lblpapel.Left + ganar;

                girarpapel++;
                if (girarpapel > 2)
                    girarpapel = 0;
                lblpapel.ImageIndex = girarpapel;

                this.Refresh();

            }
            this.Close();
            Form perdiste = new perdiste();
            perdiste.Show();
            SoundPlayer disparo = new SoundPlayer();
            disparo.Stream = Properties.Resources.perder;
            disparo.Play();


        }

 
    }
}
