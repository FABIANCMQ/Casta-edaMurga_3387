using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Clases
{
    public class ListaSimple
    {
        public Vertice primerVertice = null;
        public int cantidadVisitados = 0;

        public void AgregarVisitado(Vertice c)
        {
            Vertice nuevoVertice = new Vertice();
            nuevoVertice.dato = c.dato;
            nuevoVertice.lista_Arista = c.lista_Arista;

            if (primerVertice != null)
            {
                Vertice temp = primerVertice;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevoVertice;
            }
            else
            {
                primerVertice = nuevoVertice;
            }
            cantidadVisitados++;
        }

        public bool BuscarVisitados(Vertice c)
        {
            Vertice temp = primerVertice;
            while(temp != null)
            {
                if(temp.dato == c.dato)
                {
                    return true;
                }
                temp = temp.sig;
            }
            return false;
        }
    }
    public class ListaSimpleDistancias
    {
        public class NodoDistancia
        {
            public Vertice vertice;
            public int costo;
            public Vertice previo;
            public NodoDistancia siguiente = null;
        }
        public NodoDistancia primerNodo = null;
        public int cantidadNodos = 0;

        public void AgregarDistancias(Vertice c, int costo, Vertice previo)
        {
            NodoDistancia nuevoNodo = new NodoDistancia();
            nuevoNodo.vertice = c;
            nuevoNodo.costo = costo;
            nuevoNodo.previo = previo;

            if (primerNodo != null)
            {
                NodoDistancia temp = primerNodo;
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoNodo;
            }
            else
            {
                primerNodo = nuevoNodo;
            }
                cantidadNodos++;
        }
        public NodoDistancia ObtenerNodos(Vertice c)
        {
            NodoDistancia temp = primerNodo;
            while (temp != null)
            {
                if(temp.vertice == c)
                {
                    return temp;
                }
                temp = temp.siguiente;
            }
            return null;
        }
    }
}
