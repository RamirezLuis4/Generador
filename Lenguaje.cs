//Luis Angel Ramirez Peña
using System;
using System.Collections.Generic;

namespace Generador
{
    public class Lenguaje : Sintaxis, IDisposable
    {
         public void Dispose()
        {
            cerrar(); 
            Console.WriteLine("Destructor");
        }
       
    }

}