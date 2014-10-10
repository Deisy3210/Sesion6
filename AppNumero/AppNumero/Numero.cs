using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumero
{
    class Numero
    {
        //Atributos
        int numeromayor;
        int numeromenor;

        //Constructor con parámetros

        public Numero(int numeromenor, int numeromayor)
        {
            this.numeromenor = numeromenor;
            this.numeromayor = numeromayor;

        }

        //Get y Set
        public int Numeromenor
        {
            get { return numeromenor; }
            set { numeromenor = value; }
        }

        public int Numeromayor
        {
            get { return numeromayor; }
            set { numeromayor = value; }
        }

        // Método transaccional= Operaciones 

        public List<int> MostrarRango()
        {
            List<int> Rango = new List<int>();
            for (int contador = numeromenor; contador <= Numeromayor; contador++)
            {
                Rango.Add(contador);
            }
            return Rango;
        }

    }
}
