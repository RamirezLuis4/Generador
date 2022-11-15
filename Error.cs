//Luis Angel Ramirez Peña
using System;
using System.IO;

namespace Generador
{
    public class Error : Exception
    {
        public Error(string mensaje, StreamWriter log)
        {
            log.WriteLine(mensaje);
        }
    }
}