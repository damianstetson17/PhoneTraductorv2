using System;
using System.Collections.Generic;

namespace Telefono_App.Controllers
{
    /*  
        The TextController class
        This class contains all necessary methods for process a text input
    */
    public class CharController
    {
        string btn2 = "abc";
        string btn3 = "def";
        string btn4 = "ghi";
        string btn5 = "jkl";
        string btn6 = "mno";
        string btn7 = "pqrs";
        string btn8 = "tuv";
        string btn9 = "wxyz";

        public string getSecuence(string wordToTransform)
        {
            string secuence = "";
            string nextNumberSecuence = "";

            if (wordToTransform.Length > 0)
            {
                secuence = getLetterNumber(wordToTransform[0]);
                for (int i = 1; i < wordToTransform.Length; i++)
                {
                    nextNumberSecuence = getLetterNumber(wordToTransform[i]);
                    if (nextNumberSecuence[nextNumberSecuence.Length-1] == secuence[secuence.Length-1])
                    {
                        secuence += $" {nextNumberSecuence}";
                    }
                    else
                    {
                        secuence += $"{nextNumberSecuence}";
                    }
                }
            }
            else
            {
                throw new Exception("Empty word provided.");
            }
            Console.WriteLine($"{wordToTransform} => {secuence}");
            return secuence;
        }

        string getManyRepetitions(string letterRepeat, int many)
        {
            Console.WriteLine($"{letterRepeat} a repetir: {many}");
            string letterRepeatString = letterRepeat;

            if (many == 1)
            {
                letterRepeatString = $"{letterRepeatString}{letterRepeatString}";
            }
            else if (many == 2)
            {
                letterRepeatString = $"{letterRepeatString}{letterRepeatString}{letterRepeatString}";
            }else if(many ==  3)
            {
                letterRepeatString = $"{letterRepeatString}{letterRepeatString}{letterRepeatString}{letterRepeatString}";
            }

            return letterRepeatString;
        }

        string getLetterNumber(char letterToTransform)
        {
            string number = "";
            if (letterToTransform == ' ')
            {
                number = "0";
            }else{
                if (this.btn2.Contains(letterToTransform))
                {
                    number = getManyRepetitions("2", btn2.IndexOf(letterToTransform));
                }
                else if (this.btn3.Contains(letterToTransform))
                {
                    number = getManyRepetitions("3", btn3.IndexOf(letterToTransform));
                }
                else if (this.btn4.Contains(letterToTransform))
                {
                    number = getManyRepetitions("4", btn4.IndexOf(letterToTransform));
                }
                else if (this.btn5.Contains(letterToTransform))
                {
                    number = getManyRepetitions("5", btn5.IndexOf(letterToTransform));
                }
                else if (this.btn6.Contains(letterToTransform))
                {
                    number = getManyRepetitions("6", btn6.IndexOf(letterToTransform));
                }
                else if (this.btn7.Contains(letterToTransform))
                {
                    number = getManyRepetitions("7", btn7.IndexOf(letterToTransform));
                }
                else if (this.btn8.Contains(letterToTransform))
                {
                    number = getManyRepetitions("8", btn8.IndexOf(letterToTransform));
                }
                else if (this.btn9.Contains(letterToTransform))
                {
                    number = getManyRepetitions("9", btn9.IndexOf(letterToTransform));
                }
                else
                {
                    number = Char.ToString(letterToTransform);
                }   
            }
            return number;
        }
    }
}