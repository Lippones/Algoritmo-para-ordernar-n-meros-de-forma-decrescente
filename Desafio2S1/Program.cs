using System;

namespace Desafio2S1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio 2 semana 1");
            float[] valores = new float[3];
            ler(valores);
            classificar(valores);
            Console.Clear();
            mostrar(valores);
            Console.ReadKey();
            Console.WriteLine("Aperte qualquer tecla para sair...");
        }

        static void ler (float[] valores)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite {i + 1}° numero");
                valores[i] = float.Parse(Console.ReadLine());
            }
        }
        static void classificar(float [] v)
        {
            float aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[j];
                        v[j] = v[i];
                        v[i] = aux;
                    }
                }
            }
            
        }
        static void mostrar(float [] resultado)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(resultado[i]);
            }
        }


    }
}
