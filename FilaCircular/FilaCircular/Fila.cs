 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaCircular
{
    internal class Fila
    {
        string[] valores;
        int inicio, fim, total;

        public Fila(int Tamanho)
        {
            valores = new string[Tamanho];
            inicio = 0;
            fim = -1;
            total = 0;
        }

        public void Enfileirar(string Valor)
        {
            if (total < valores.Length){
                fim = (fim + 1) % valores.Length;
                valores[fim] = Valor;  
                total++;
            }
            else
            {
                Console.WriteLine("Fila está cheia");
                Console.ReadKey();
            }
        }

        public string Desenfileirar()
        {
            if (total > 0)
            {
                string valor = valores[inicio];
                valores[inicio] = string.Empty;
                inicio = (inicio + 1) % valores.Length;
                total--;
                return valor;
            }
            else
            {
                Console.WriteLine("Fila está vazia!");
                Console.ReadKey();
                return null;
            }
        }


        public void Imprimir()
        {
            if (total == 0)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            int i = inicio;
            for (int count = 0; count < total; count++)
            {
                Console.WriteLine(valores[i]);
                i = (i + 1) % valores.Length;
            }
        }

    }
}
