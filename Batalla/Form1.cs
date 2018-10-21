using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batalla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuerra_Click(object sender, EventArgs e)
        {
            Nave naveT = new Nave("Terricolas");
            Nave naveM = new Nave("Marcianos");

            while(naveT.cuantosQuedan() > 0 && naveM.cuantosQuedan() > 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    naveT.recibirDisparo(naveM.generarDisparo(i));
                    naveM.recibirDisparo(naveT.generarDisparo(i));
                }
            }

            if (naveT.cuantosQuedan() > 0)
                txtInfo.Text = "Ganan Terricolas";
            else
                txtInfo.Text = "Ganan Marcianos";

        }
    }
}