using System;

namespace criptografador
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("msg: ");
                string msg = Console.ReadLine();
                msg = msg.Replace(' ', '_');
                string allCaracters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int key = 3;
                string msgCripted = "";

                for (int numberCaracter = 0; numberCaracter < msg.Length; numberCaracter++)
                {
                    char caracter = msg[numberCaracter];
                    if (caracter == '_')
                    {
                        msgCripted += ".";
                    }
                    else
                    {
                        int numberInAllCaracters = allCaracters.IndexOf(caracter);
                        int newNumberCaracter = numberInAllCaracters + key;
                        char newCaracter = allCaracters[newNumberCaracter];
                        msgCripted += newCaracter;
                    }
                }
                Console.WriteLine(msgCripted);
            }
        }
    }
}
