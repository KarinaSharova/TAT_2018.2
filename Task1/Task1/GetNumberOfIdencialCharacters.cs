using System.Collections.Generic;

namespace Task1
{
    //gets and returns pairs(symbol / number of repetitions)
    class NumbersOfIdencialCharacters
    {
        //gets pairs(symbol / number of repetitions)
        public Dictionary<char, int> GetNumbersOfIdencialCharacters(string sequenceOfCharacters)
        {
            //pairs(symbol / number of repetitions)
            Dictionary<char, int> uniqueCharacters = new Dictionary<char, int>();
            uniqueCharacters.Add(sequenceOfCharacters[0], 0);

            //checks if this character is in the already existing sequence. 
            //If not, adds it. If there is, adds 1 to the amount
            foreach (var item in sequenceOfCharacters)
            {
                if (!uniqueCharacters.ContainsKey(item))
                {
                    uniqueCharacters.Add(item, 1);
                }
                else
                {
                    uniqueCharacters[item]++;
                }
            }
            return uniqueCharacters;
        }
    }
}
