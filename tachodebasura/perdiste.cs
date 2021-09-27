using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tachodebasura
{
    public partial class perdiste : Form
    {
        public perdiste()
        {
            InitializeComponent();
        }

        private void btvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form jugar = new jugar();
            jugar.Show();
        }
    }
}
