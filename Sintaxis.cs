//Luis Angel Ramirez Peña
using System;

namespace Generador
{
    public class Sintaxis : Lexico
    {
        public Sintaxis()
        {
            NextToken();
        }
        public Sintaxis(string nombre) : base(nombre)
        {
            NextToken();
        }

        public void match(string espera)
        {
            if (espera == getContenido())
            {
                NextToken();
            }
        }

        public void match(Tipos espera)
        {
            if (espera == getClasificacion())
            {
                NextToken();
            }
            else
            {
                throw new Error("Error de sintaxis, se espera un " +espera+" en linea: "+linea , log);
            }
        }
    }
}