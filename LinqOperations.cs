using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationCSharp
{
    public class LinqOperations
    {
        string[] numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        public string FirstNumberLengthGreaterThanThree()
        {
            return $"The first number with length greater than 3 is: {numbers.FirstOrDefault(n => n.Length > 3)}";
        }
        public string CountNumbersLengthGreaterThanThree()
        {
            return $"The count of numbers length greater than 3 are: {numbers.Count(n => n.Length > 3)}";
        }

        public string NumbersLengthGreaterThanThree()
        {
            string[] arr = numbers.Where(n => n.Length > 3).ToArray();
            return $"The numbers with length greater than 3 are: {string.Join(", ", arr)}";
        }

        public string GroupNumbersByFirstLetter()
        {
            var result = from number in numbers
                         group number by number.Substring(0, 1) into myGroup
                         orderby myGroup.Key
                         select myGroup;
            string output = "";
            foreach (var item in result)
            {
                output += item.Key + "\n";
                foreach (var number in item)
                {
                    output += number + "\n";
                }
            }
            return output;
        }

        public void GroupNumbersByKey()
        {
            var result = from number in numbers
                         group number by number.Substring(0, 1) into myGroup
                         orderby myGroup.Key
                         select myGroup;
            Console.WriteLine("Grouping numbers by first letter:");

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var number in item)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}

