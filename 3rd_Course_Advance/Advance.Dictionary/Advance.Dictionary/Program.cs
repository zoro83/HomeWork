using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<char, string> charTranlsation = new Dictionary<char, string>(30);
            charTranlsation.Add('a', "ա");      charTranlsation.Add('A', "Ա"); 
            charTranlsation.Add('b', "բ");      charTranlsation.Add('B', "Բ");
            charTranlsation.Add('c', "ց");      charTranlsation.Add('C', "Ց");
            charTranlsation.Add('d', "դ");      charTranlsation.Add('D', "Դ");
            charTranlsation.Add('e', "ե");      charTranlsation.Add('E', "Ե");
            charTranlsation.Add('f', "ֆ");      charTranlsation.Add('F', "Ֆ");
            charTranlsation.Add('g', "գ");      charTranlsation.Add('G', "Գ");
            charTranlsation.Add('h', "հ");      charTranlsation.Add('H', "Հ");
            charTranlsation.Add('i', "ի");      charTranlsation.Add('I', "Ի");
            charTranlsation.Add('j', "ջ");      charTranlsation.Add('J', "Ջ");
            charTranlsation.Add('k', "կ");      charTranlsation.Add('K', "Կ");
            charTranlsation.Add('l', "լ");      charTranlsation.Add('L', "Լ");
            charTranlsation.Add('m', "մ");      charTranlsation.Add('M', "Մ");
            charTranlsation.Add('n', "ն");      charTranlsation.Add('N', "Ն");
            charTranlsation.Add('o', "օ");      charTranlsation.Add('O', "Օ");
            charTranlsation.Add('p', "պ");      charTranlsation.Add('P', "Պ");
            charTranlsation.Add('q', "ք");      charTranlsation.Add('Q', "Ք");
            charTranlsation.Add('r', "ռ");      charTranlsation.Add('R', "Ռ");
            charTranlsation.Add('s', "ս");      charTranlsation.Add('S', "Ս");
            charTranlsation.Add('t', "տ");      charTranlsation.Add('T', "Տ");
            charTranlsation.Add('u', "ու");     charTranlsation.Add('U', "Ու");
            charTranlsation.Add('v', "վ");      charTranlsation.Add('V', "Վ");
            charTranlsation.Add('w', "վ");      charTranlsation.Add('W', "Վ");
            charTranlsation.Add('x', "խ");      charTranlsation.Add('X', "Խ");
            charTranlsation.Add('y', "ու");     charTranlsation.Add('Y', "Ու");
            charTranlsation.Add('z', "զ");      charTranlsation.Add('Z', "Զ");
            charTranlsation.Add('@', "ը");

            Console.WriteLine("Latin leters armenian.ConvertTo(armenian)");
            string inputText = "";
            try
            {
                inputText = Console.ReadLine(); // input text
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            //char[] InputByLetters = new char[inputText.Length];
            string outputText = "";

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] >= 64 && inputText[i] <= 90 || inputText[i] >= 97 && inputText[i] <= 122)
                {
                    //InputByLetters[i] = inputText[i];
                    outputText += charTranlsation[inputText[i]];
                }
                else
                {
                    outputText += inputText[i];
                }
            }
            Console.WriteLine(outputText);
            //Console.WriteLine(Convert.ToInt32('a')); // 97
            //Console.WriteLine(Convert.ToInt32('A')); // 65
            //Console.WriteLine(Convert.ToInt32('z')); // 122
            //Console.WriteLine(Convert.ToInt32('Z')); // 90
            //Console.WriteLine(Convert.ToInt32('@')); // 64
            Console.ReadKey();
           
        }
    }
}
