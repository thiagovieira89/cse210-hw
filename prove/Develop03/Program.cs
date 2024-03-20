using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";

        while (answer != "quit")
        {
            
            Reference reference = new Reference("John", 3, 16,0);
            string scripture = reference.GetDisplayText();
            Console.Write(scripture);

            Word text = new Word(" For God so loved the world, that he dgave his only begotten Son, that whosoever believeth in him should not perish, but have heverlasting life.");
            string verse = text.GetDisplayText();
            Console.WriteLine(verse);
            Console.WriteLine("Press enter to cotinue or 'quit' to finish: ");
            answer = Console.ReadLine();

        }


    }
}