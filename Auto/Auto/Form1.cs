using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool erstellung = false;
        string marke, farbe;
        int tankgroeße, ps, verbrauch;
        private void Erstellen_Click(object sender, EventArgs e)
        {
            marke = Marke.Text;
            farbe = Farbe.Text;
            tankgroeße = Convert.ToInt32(Tankgroeße.Text);
            ps = Convert.ToInt32(PS.Text);
            verbrauch = Convert.ToInt32(Verbrauch.Text);
            erstellung = true;
            Info();
        }


        private void Tankenb_Click(object sender, EventArgs e)
        {
            if(erstellung==true){
            
            
            
            
            
            }
        }

        private void Fahrenb_Click(object sender, EventArgs e)
        {
            if (erstellung == true)
            {





            }

        }
        private void Info()
        {
            Informationen.Text = "Marke: " + marke+"\ngefahren: ";



        }
        class auto {
            private void tanken() {
            
            
            
            
            }
        
        }

       

       
    }
}
