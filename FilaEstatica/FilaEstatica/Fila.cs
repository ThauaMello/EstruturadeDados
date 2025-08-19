using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilaEstatica
{
    
    internal class Fila
    {

        string[] fila;
        int primeiro;
        int ultimo;

        public Fila(int Tamanho)
        {
            fila = new string[Tamanho];
            primeiro = 0;
            ultimo = 0;
        }

        public void Enfileirar(String valor)
        {
            if (ultimo < fila.Length)
            {
                fila[ultimo] = valor;
                ultimo++;
            }
            else
            {
                Console.WriteLine("Valor Cheia!");
            }
        }
        public void Imprimir()
            {
                for (int i = 0; i < fila.Length; i++)
                {
                Console.WriteLine(fila[i]);
                }
            }
    }
}
