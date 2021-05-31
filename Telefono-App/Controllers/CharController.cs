using System;
using Telefono_App.Models;
using System.Collections.Generic;

namespace Telefono_App.Controllers
{
    /*  
        The TextController class
        This class contains all necessary methods for process a text input
    */
    public class CharController
    {
        public List<Button> buttons = new List<Button>();

        /*  
            Constructor overload
            An empty constructor set a phone buttons pattern
        */
        public CharController()
        {
            buttons.Add(new Button("abc",  "2"));
            buttons.Add(new Button("def",  "3"));
            buttons.Add(new Button("ghi",  "4"));
            buttons.Add(new Button("jkl",  "5"));
            buttons.Add(new Button("mno",  "6"));
            buttons.Add(new Button("pqrs", "7"));
            buttons.Add(new Button("tuv",  "8"));
            buttons.Add(new Button("wxyz", "9"));
        }

        public CharController(List<Button> buttons)
        {
            this.buttons = buttons;
        }

        /*
            This method returns the complete number secuence of a word
        */
        public string getSecuence(string wordToTransformParameter)
        {
            string secuence = "";
            string nextNumberSecuence = "";
            string wordToTransform = wordToTransformParameter.ToLower();

            if (wordToTransform.Length > 0)
            {
                secuence = getLetterNumber(wordToTransform[0]);
                for (int i = 1; i < wordToTransform.Length; i++)
                {
                    nextNumberSecuence = getLetterNumber(wordToTransform[i]);
                    if (nextNumberSecuence[nextNumberSecuence.Length - 1] == secuence[secuence.Length - 1])
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

        /*
            This methods return the number with it needed repetitions
        */
        string getManyRepetitions(string letterRepeat, int many)
        {
            string letterRepeatString = letterRepeat;

            if (many == 1)
            {
                letterRepeatString = $"{letterRepeatString}{letterRepeatString}";
            }
            else if (many == 2)
            {
                letterRepeatString = $"{letterRepeatString}{letterRepeatString}{letterRepeatString}";
            }
            else if (many == 3)
            {
                letterRepeatString = $"{letterRepeatString}{letterRepeatString}{letterRepeatString}{letterRepeatString}";
            }

            return letterRepeatString;
        }

        /*
            This method returns the number of a char
        */
        string getLetterNumber(char letterToTransform)
        {
            string number = "";
            if (letterToTransform == ' ')
            {
                number = "0";
            }
            else
            {
                foreach (Button b in this.buttons)
                {
                    if (b.isIn(letterToTransform))
                    {
                        number = getManyRepetitions(b.buttonNumber, b.getIndexChar(letterToTransform));
                    }
                }
                if(number == "")
                {
                    number = Char.ToString(letterToTransform);
                }
            }
            return number;
        }
    }
}