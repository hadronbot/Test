using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
            var convidados = new List<string>();

            convidados.Add("convidado1");
            convidados.Add("convidado2");
            convidados.Add("convidado3");

            foreach (var convidado in convidados)
            {
                Console.WriteLine(convidado);
            }

            Console.WriteLine("Comecando a alteracao");
		}
	}
}
