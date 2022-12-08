using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsArbolesBinariosBusqueda
{
    internal class Nodo
    {
        private int info;
        private Nodo hijoizquierdo;
        private Nodo hijoderecho;
        public Nodo(int info)
        {
            this.Info=info;
            this.hijoizquierdo = null;
            this.hijoderecho = null;
        }

        public int Info { get; set; }
        public Nodo HijoIzquierdo { get; set; }
        public Nodo HijoDerecho { get; set; }

    }
}
