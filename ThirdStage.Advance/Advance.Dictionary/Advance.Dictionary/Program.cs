using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Advance.Dictionary
{
    public static class SpellingExtension
    {
        public static string Spelling(this string str) //ուղղագրություն
        {
            str = str.Replace("ch", "չ");
            str = str.Replace("gh", "ղ");
            str = str.Replace("Ch", "Չ");
            str = str.Replace("Gh", "Ղ");
            str = str.Replace("ev", "և");
            str = str.Replace("Ev", "Եվ");
            str = str.Replace("dz", "ձ");
            str = str.Replace("Dz", "Ձ");
            str = str.Replace("vo", "ո");
            str = str.Replace("Vo", "Ո");
            str = str.Replace("ph", "փ");
            str = str.Replace("Ph", "Փ");
            str = str.Replace("th", "թ");
            str = str.Replace("Th", "Թ");
            str = str.Replace("ye", "ե");
            str = str.Replace("Ye", "Ե");
            return str;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<char, string> charTranlsation = new Dictionary<char, string>(30);
            charTranlsation.Add('a', "ա"); charTranlsation.Add('A', "Ա");
            charTranlsation.Add('b', "բ"); charTranlsation.Add('B', "Բ");
            charTranlsation.Add('c', "ց"); charTranlsation.Add('C', "Ց");
            charTranlsation.Add('d', "դ"); charTranlsation.Add('D', "Դ");
            charTranlsation.Add('e', "ե"); charTranlsation.Add('E', "Ե");
            charTranlsation.Add('f', "ֆ"); charTranlsation.Add('F', "Ֆ");
            charTranlsation.Add('g', "գ"); charTranlsation.Add('G', "Գ");
            charTranlsation.Add('h', "հ"); charTranlsation.Add('H', "Հ");
            charTranlsation.Add('i', "ի"); charTranlsation.Add('I', "Ի");
            charTranlsation.Add('j', "ջ"); charTranlsation.Add('J', "Ջ");
            charTranlsation.Add('k', "կ"); charTranlsation.Add('K', "Կ");
            charTranlsation.Add('l', "լ"); charTranlsation.Add('L', "Լ");
            charTranlsation.Add('m', "մ"); charTranlsation.Add('M', "Մ");
            charTranlsation.Add('n', "ն"); charTranlsation.Add('N', "Ն");
            charTranlsation.Add('o', "ո"); charTranlsation.Add('O', "Ո");
            charTranlsation.Add('p', "պ"); charTranlsation.Add('P', "Պ");
            charTranlsation.Add('q', "ք"); charTranlsation.Add('Q', "Ք");
            charTranlsation.Add('r', "ր"); charTranlsation.Add('R', "Ր");
            charTranlsation.Add('s', "ս"); charTranlsation.Add('S', "Ս");
            charTranlsation.Add('t', "տ"); charTranlsation.Add('T', "Տ");
            charTranlsation.Add('u', "ու"); charTranlsation.Add('U', "Ու");
            charTranlsation.Add('v', "վ"); charTranlsation.Add('V', "Վ");
            charTranlsation.Add('w', "վ"); charTranlsation.Add('W', "Վ");
            charTranlsation.Add('x', "խ"); charTranlsation.Add('X', "Խ");
            charTranlsation.Add('y', "յ"); charTranlsation.Add('Y', "Յ");
            charTranlsation.Add('z', "զ"); charTranlsation.Add('Z', "Զ");
            charTranlsation.Add('@', "ը"); charTranlsation.Add('.', ":");

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
            inputText = inputText.Spelling();
            string outputText = "";

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] >= '@' && inputText[i] <= 'Z' || 
                    inputText[i] >= 'a' && inputText[i] <= 'z' || inputText[i] == '.')
                {
                    outputText += charTranlsation[inputText[i]];
                }
                else
                {
                    outputText += inputText[i];
                }
            }
            Console.WriteLine(outputText);

            Console.ReadKey();

        }
    }
}
