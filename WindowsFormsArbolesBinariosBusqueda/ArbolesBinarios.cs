using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsArbolesBinariosBusqueda
{
    internal class ArbolesBinarios
    {
        private Nodo raiz;
        public ArbolesBinarios()
        {
            this.Raiz = null;
            
            
        }
        public Nodo Raiz { get; set; }
        public void AgregarNodo(int info)
        {
            
            Nodo nuevo=new Nodo(info);
            if (this.Raiz == null)
            {
                this.Raiz= nuevo;
            }
            else
            {
                Nodo auxiliar = this.Raiz;
                Nodo padre;
                while (true)
                {
                    padre = auxiliar;
                    if (info < auxiliar.Info)
                    {
                        Console.WriteLine(auxiliar.Info);
                        auxiliar = auxiliar.HijoIzquierdo;
                        if (auxiliar == null)
                        {
                            padre.HijoIzquierdo = nuevo;
                            return;
                        }
                    }
                    else
                    {
                        auxiliar = auxiliar.HijoDerecho;
                        if(auxiliar == null)
                        {
                            padre.HijoDerecho= nuevo;
                            return;
                        }
                    }
                }
            }
        }
        public bool EstaVacio()
        {
            return this.Raiz == null;
        }
        public void EntreOrden(Nodo r,TextBox text)
        {
            if (r != null)
            {
                EntreOrden(r.HijoIzquierdo,text);
                text.Text += r.Info.ToString()+" - ";
                EntreOrden(r.HijoDerecho, text);

            }
        }
        public void PreOrden(Nodo r, TextBox text)
        {
            if (r != null)
            {
                text.Text += r.Info.ToString() + " - ";
                PreOrden(r.HijoIzquierdo, text);
                PreOrden(r.HijoDerecho, text);

            }
        }
        public void PostOrden(Nodo r, TextBox text)
        {
            if (r != null)
            {
                
                PostOrden(r.HijoIzquierdo, text);
                PostOrden(r.HijoDerecho, text);
                text.Text += r.Info.ToString() + " - ";

            }
        }


    }
}
