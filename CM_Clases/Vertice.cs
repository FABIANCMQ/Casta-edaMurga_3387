using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Clases
{
    public class Vertice
    {
        public string dato;

        public Vertice sig = null;

        public Arista lista_Arista = null;

        public void InsertarArista(Vertice d, int c)
        {
            Arista nuevo = new Arista();
            nuevo.destino = d;
            nuevo.costo = c;

            if (lista_Arista != null)
            {
                Arista temp = lista_Arista;
                while (temp != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
            else
            {
                lista_Arista = nuevo;
            }
        }

        public void MostrarAristas()
        {
            Arista temp = lista_Arista;
            int i = 1;
            while (temp != null)
            {
                Console.WriteLine($"{i}. {temp.destino.dato} ({temp.costo} km)");
                temp = temp.sig;
                i++;
            }
        }
    }
}
