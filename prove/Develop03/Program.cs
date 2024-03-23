using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{

    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16,0);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have heverlasting life.";

        Scriptures scriptures = new Scriptures(reference, text);
        string answer = "";
        bool first = true;
        List<int> listaNumeros = new List<int>();
        while (answer != "quit")
        {
            if(!first){
                Random random = new Random();
                int numero = random.Next(scriptures.getWords().Count);
                while(listaNumeros.Contains(numero) && !scriptures.isCompletelyHidden())
                {
                    numero = random.Next(scriptures.getWords().Count);
                }

                if(!scriptures.isCompletelyHidden()){
                    listaNumeros.Add(numero);
                    Console.WriteLine(numero);
                    scriptures.HideRandomWords(numero);
                }else{
                    break;
                }
            }else{
                first = false;
            }

            string verse = scriptures.GetDisplayText();
            Console.WriteLine(verse);
            Console.WriteLine("Press enter to cotinue or 'quit' to finish: ");
            answer = Console.ReadLine();
        }
    }
}