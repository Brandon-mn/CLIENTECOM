using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENTECOM
{
     class Program
    {
        static void Main()
        {
            try
            {
                var servidorDCOM = COM_DCOM.SERVIDOR();
                string resultado = servidorDCOM.ObtenerSaludo("UsuarioDCOM");
                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
