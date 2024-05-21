using Bunifu.UI.WinForms.Extensions;
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
    public partial class Ubicacion_Almacen : Form
    {
        public Ubicacion_Almacen()
        {
            InitializeComponent();
        }

        private void Cerrar_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Btn_Click(object sender, EventArgs e)
        {
            this.Minimize();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void OlvidarCredenciales_TextLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvidarCredenciales newForm = new OlvidarCredenciales();
            newForm.Show();
        }

        private void IniciarSesion_Btn_Click(object sender, EventArgs e)
        {
            MenuPrincipal newForm = new MenuPrincipal();
            newForm.Show();
        }
    }
}
