using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsArbolesBinariosBusqueda
{
    public partial class Form1 : Form
    {
        ArbolesBinarios ab;
        public Form1()
        {
            ab = new ArbolesBinarios();
            InitializeComponent();
        }

        private void btninsertarnodos_Click(object sender, EventArgs e)
        {
            ab.AgregarNodo(int.Parse(txthijo.Text));
            if (ab.EstaVacio())
            {
                MessageBox.Show("El arbol esta vacio");
            }
            else
            {
                txtentreorden.Clear();
                txtpreorden.Clear();
                txtposorden.Clear();
                ab.EntreOrden(ab.Raiz, txtentreorden);
                ab.PreOrden(ab.Raiz, txtpreorden);
                ab.PostOrden(ab.Raiz, txtposorden);

            }
        }

        private void btncreararbol_Click(object sender, EventArgs e)
        {
            
        }
    }
}
