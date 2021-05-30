namespace Telefono_App.Models
{
    public class Button
    {
        public string characters {get; private set;}
        public string buttonNumber  {get; private set;}

        public Button(string characters, string buttonNumber){
            this.characters = characters;
            this.buttonNumber = buttonNumber;
        }

        /*
            This methods verify if contains a char and return true or false
        */
        public bool isIn(char letter){
            return this.characters.Contains(letter);
        }

        /*
            This method returns the index of the letter in characters
        */
        public int getIndexChar(char letterIndex){
            return characters.IndexOf(letterIndex);
        }
    }
}