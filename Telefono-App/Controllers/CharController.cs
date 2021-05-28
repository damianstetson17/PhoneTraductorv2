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

            if(wordToTransform.Length > 0)
            {
                secuence = Char.ToString(wordToTransform[0]);
                for (int i = 1; i < wordToTransform.Length; i++)
                {
                    nextNumberSecuence = getLetterNumber(wordToTransform[i]);
                    //nextNumberSecuence == Char.ToString(secuence[-1]) ? secuence +=$" {nextNumberSecuence}" : secuence +=$"{nextNumberSecuence}";
                    if(nextNumberSecuence == Char.ToString(secuence[-1]))
                    {
                        secuence +=$" {nextNumberSecuence}";
                    }else{
                        secuence +=$"{nextNumberSecuence}";
                    }
                }
            }else{
                throw new Exception("Empty word provided.");
            }

            return secuence;
        }

        string getManyRepetitions(int many, char letterRepeat)
        {
            string letterRepeatString = Char.ToString(Char.ToLower(letterRepeat));
            if (many == 0)
            {
                letterRepeatString = letterRepeatString;
            }else{
                if( many == 1)
                {
                    letterRepeatString = $"{letterRepeatString}{letterRepeatString}";
                }else{
                    if( many == 2)
                    {
                        letterRepeatString = $"{letterRepeatString}{letterRepeatString}{letterRepeatString}";
                    }else{
                        letterRepeatString = $"{letterRepeatString}{letterRepeatString}{letterRepeatString}{letterRepeatString}";
                    }
                }
            }
            return letterRepeatString;
        }

        string getLetterNumber(char letterToTransform)
        {
            string number = "";
            //letterToTransform = Char.ToString(letterToTransform);
           switch (letterToTransform)
           {
               case this.btn2.Contains(letterToTransform):
                    number = getManyRepetitions(letterToTransform,btn2.IndexOf(letterToTransform));
                    break;
                case this.btn3.Contains(letterToTransform):
                    number = getManyRepetitions(letterToTransform,btn2.IndexOf(letterToTransform));
                    break;
                case this.btn4.Contains(letterToTransform):
                    number = getManyRepetitions(letterToTransform,btn2.IndexOf(letterToTransform));
                    break;
                case this.btn5.Contains(letterToTransform):
                    number = getManyRepetitions(letterToTransform,btn2.IndexOf(letterToTransform));
                    break;
                case this.btn6.Contains(letterToTransform):
                    number = getManyRepetitions(letterToTransform,btn2.IndexOf(letterToTransform));
                    break;
                case this.btn7.Contains(letterToTransform):
                    number = getManyRepetitions(letterToTransform,btn2.IndexOf(letterToTransform));
                    break;
                case this.btn8.Contains(letterToTransform):
                    number = getManyRepetitions(letterToTransform,btn2.IndexOf(letterToTransform));
                    break;
                case this.btn9.Contains(letterToTransform):
                    number = getManyRepetitions(letterToTransform,btn2.IndexOf(letterToTransform));
                    break;
               default:number = letterToTransform;
           }
            return number;
        }
    }
}