using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersona
{
    class Persona
    {
        //Declarar atributos
        string nombre;
        int edad;

        //Constructor de la clase
        
        public Persona()
        {
            
        }

        //Constructor con Parámetros
        public Persona(string nombre, int edad)
        {
            this.nombre=nombre;
            this.edad=edad;
        }

        //Metodos get y set
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        
        public int Edad
        {
            get { 
                    return edad;
                }

            set {
                    edad = value;
                }
         }

        //Metodos transaciones



    }
}
