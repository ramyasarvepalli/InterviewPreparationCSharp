using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationCSharp
{
    public class StringOperations
    {
        public string firstName = "Ramya";
        public string middleName = "Krishna";
        public string lastName = "Sarvepalli";

        public string MyString = "Hello World!";

        public string untrimmed = "    Hello World!    ";

        public string[] fruits = { "Apple", "Banana", "Cherry" };

        public string sentence = "This is a sample sentence";

        public string MyFunction()
        {
            return "Hi from StringFunctions class";
        }

        //Concatenation
        public string Concatenation()
        {
            return string.Concat(firstName, " ", middleName, " ", lastName);
        }

        //Length
        public void StringLength()
        {
            Console.WriteLine($"The string length of \"{MyString}\" is: " + MyString.Length);
        }

        //IndexOf
        public void IndexOf()
        {
            Console.WriteLine($"The index of 'World' in \"{MyString}\" is: " + MyString.IndexOf("World"));
            Console.WriteLine($"The first char of \"{MyString}\" is: " + MyString[0]);
        }

        //SubString
        public void SubString()
        {
            Console.WriteLine($"The substring of \"{MyString}\" is: " + MyString.Substring(6, 5));
        }

        //ToUpper,ToLower
        public void ToUpperToLower()
        {
            Console.WriteLine($"The string \"{MyString}\" in uppercase is: " + MyString.ToUpper());
            Console.WriteLine($"The string \"{MyString}\" in lowercase is: " + MyString.ToLower());
        }

        //Trim
        public void Trim()
        {
            Console.WriteLine($"The string \"{untrimmed}\" after trimming is: " + untrimmed.Trim());
        }

        //Replace
        public void Replace()
        {
            Console.WriteLine($"The string \"{MyString}\" after replacing 'World' with 'Universe' is: " + MyString.Replace("World", "Universe"));
        }

        //Join
        public void JoinStrings()
        {
            Console.WriteLine($"The string after joining the fruits array is: " + string.Join(", ", fruits));
        }

        //Split
        public void SplitString()
        {
            string[] words = sentence.Split(' ');
            Console.WriteLine("The words in the sentence after splitting are: ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        //Compare
        public void CompareStrings()
        {
            Console.WriteLine($"The comparison of \"{firstName}\" and \"{middleName}\" is: " + string.Compare(firstName, middleName));
            Console.WriteLine($"The comparison of \"{firstName}\" and \"{firstName}\" is: " + string.Compare(firstName, firstName));
        }

        //Contains
        public void ContainsString()
        {
            Console.WriteLine($"The string \"{MyString}\" contains 'World': " + MyString.Contains("World"));
        }
    }
}
