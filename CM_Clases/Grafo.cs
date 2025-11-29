using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CM_Clases
{
    public class Grafo
    {
        public Vertice primero_lista = null;
        public int[,] ma;

        public Grafo(int n)
        {
            ma = new int[n,n];
        }

        public void LugaresTuristicos()
        {
            Console.WriteLine(new string('=', 70));
            Console.WriteLine("Sistema de Rutas Turísticas - Cajamarca");
            Console.WriteLine("Cargando lugares turísticos... \n");

            string[] lugaresTuristicos = { "Plaza de Armas", "Baños del Inca", "Ventanillas de Otuzco", "Hacienda la colpa", "Llacanora", "Granja Porcon" };
            for (int i = 0;i < lugaresTuristicos.Length && i<ma.GetLength(0);i++)
            {
                Console.WriteLine($"- {i + 1}.{lugaresTuristicos[i]}");
                InsertarVertice(lugaresTuristicos[i]);
            }

            Console.WriteLine("Lugares turisticos cargados exitosamente");
        }
        public void InsertarVertice(string v)
        {
            Vertice nuevoVertice = new Vertice();
            nuevoVertice.dato = v;

            if(primero_lista!= null)
            {
                Vertice temp = primero_lista;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevoVertice;
            }
            else
            {
                primero_lista = nuevoVertice;
            }
        }
        public void MostrarVertice()
        {
            Console.WriteLine("\n" + new string('=', 70));
            Console.WriteLine("LUGARES TURISTICOS DISPONIBLES");

            Vertice temp = primero_lista;
            int contadorVertices = 1;
            while (temp != null)
            {
                Console.WriteLine($"{contadorVertices}. {temp.dato}");
                temp = temp.sig;
                contadorVertices++;
            }
            Console.WriteLine(new string('=', 70));
        }

        private void Conexiones(int origen, int destino)
        {
            ma[origen,destino] = 1;
            ma[destino,origen] = 1;
        }
        public void EstablecerConexiones()
        {
            Console.WriteLine("Estableciendo las conexiones entre los distintos lugares turisticos...");

            // 0 = Cajamarca, 1 = Baños del Inca, 2 = Ventanilla de Otuzco, 3 = Hacienda la Colpa, 4 = Llacanora, 5 = Granja Porcon

            //Cajamarca (0)
            Conexiones(0, 1);
            Conexiones(0, 2);
            Conexiones(0, 3);
            Conexiones(0, 4);
            Conexiones(0, 5);

            //Baños del inca (1)
            Conexiones(1, 2);
            Conexiones(1, 3);
            Conexiones(1, 4);
            Conexiones(1, 5);

            //Otuzco (2)
            Conexiones(2, 3);
        }
    }
}
