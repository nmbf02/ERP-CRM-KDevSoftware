using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDev
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Maximizar_Btn_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void Cerrar_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Btn_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
        }

    }
}
