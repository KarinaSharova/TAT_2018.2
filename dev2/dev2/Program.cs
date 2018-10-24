using System;

namespace dev2
{
    class Translit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text : ");
            string inputStr = Console.ReadLine();
            string outputStr = "";

            //translates string to lower case
            string inputStrLow = inputStr.ToLower();
            //translates into code
            byte[] b = System.Text.Encoding.Default.GetBytes(inputStrLow);

            int englishCount = 0;
            int russianCount = 0;

            bool english = false;
            bool russian = false;

            //checks what language is entered
            foreach (byte bt in b)
            {
                if (((bt >= 97) && (bt <= 122)) || ((bt >= 65) && (bt <= 90)))
                    englishCount++;

                if ((bt >= 192) && (bt <= 255))
                    russianCount++;
            }

            if (englishCount > 0 && russianCount == 0)
            {
                english = true;
                Console.Write("- englisn\n");
            }
            if (russianCount > 0 && englishCount == 0)
            {
                russian = true;
                Console.Write("- russian\n");
            }
            if (russianCount > 0 && englishCount > 0)
            {
                Console.Write("Error. Mix language. Translite is impossible.\n");
            }
            if (russianCount == 0 && englishCount == 0)
            {
                Console.Write("Error. Unknown language. Translite is impossible.\n");
            }

            //makes translit of russian text
            if (russian == true)
            {
                Console.Write("Translit text : ");
                for (int i = 0; i < inputStr.Length; i++)
                {
                    switch (inputStr[i])
                    {
                        case 'а': outputStr = String.Concat(outputStr, "a"); break;
                        case 'б': outputStr = String.Concat(outputStr, "b"); break;
                        case 'в': outputStr = String.Concat(outputStr, "v"); break;
                        case 'г': outputStr = String.Concat(outputStr, "g"); break;
                        case 'д': outputStr = String.Concat(outputStr, "d"); break;
                        case 'е': outputStr = String.Concat(outputStr, "e"); break;
                        case 'ё': outputStr = String.Concat(outputStr, "yo"); break;
                        case 'ж': outputStr = String.Concat(outputStr, "zh"); break;
                        case 'з': outputStr = String.Concat(outputStr, "z"); break;
                        case 'и': outputStr = String.Concat(outputStr, "i"); break;
                        case 'й': outputStr = String.Concat(outputStr, "y"); break;
                        case 'к': outputStr = String.Concat(outputStr, "k"); break;
                        case 'л': outputStr = String.Concat(outputStr, "l"); break;
                        case 'м': outputStr = String.Concat(outputStr, "m"); break;
                        case 'н': outputStr = String.Concat(outputStr, "n"); break;
                        case 'о': outputStr = String.Concat(outputStr, "o"); break;
                        case 'п': outputStr = String.Concat(outputStr, "p"); break;
                        case 'р': outputStr = String.Concat(outputStr, "r"); break;
                        case 'с': outputStr = String.Concat(outputStr, "s"); break;
                        case 'т': outputStr = String.Concat(outputStr, "t"); break;
                        case 'у': outputStr = String.Concat(outputStr, "u"); break;
                        case 'ф': outputStr = String.Concat(outputStr, "f"); break;
                        case 'х': outputStr = String.Concat(outputStr, "kh"); break;
                        case 'ц': outputStr = String.Concat(outputStr, "c"); break;
                        case 'ч': outputStr = String.Concat(outputStr, "ch"); break;
                        case 'ш': outputStr = String.Concat(outputStr, "sh"); break;
                        case 'щ': outputStr = String.Concat(outputStr, "sch"); break;
                        case 'ъ': break;
                        case 'ы': outputStr = String.Concat(outputStr, "y"); break;
                        case 'ь': break;
                        case 'э': outputStr = String.Concat(outputStr, "e"); break;
                        case 'ю': outputStr = String.Concat(outputStr, "yu"); break;
                        case 'я': outputStr = String.Concat(outputStr, "ya"); break;
                        case 'А': outputStr = String.Concat(outputStr, "A"); break;
                        case 'Б': outputStr = String.Concat(outputStr, "B"); break;
                        case 'В': outputStr = String.Concat(outputStr, "V"); break;
                        case 'Г': outputStr = String.Concat(outputStr, "G"); break;
                        case 'Д': outputStr = String.Concat(outputStr, "D"); break;
                        case 'Е': outputStr = String.Concat(outputStr, "E"); break;
                        case 'Ё': outputStr = String.Concat(outputStr, "Yo"); break;
                        case 'Ж': outputStr = String.Concat(outputStr, "Zh"); break;
                        case 'З': outputStr = String.Concat(outputStr, "Z"); break;
                        case 'И': outputStr = String.Concat(outputStr, "I"); break;
                        case 'Й': outputStr = String.Concat(outputStr, "Y"); break;
                        case 'К': outputStr = String.Concat(outputStr, "K"); break;
                        case 'Л': outputStr = String.Concat(outputStr, "L"); break;
                        case 'М': outputStr = String.Concat(outputStr, "M"); break;
                        case 'Н': outputStr = String.Concat(outputStr, "N"); break;
                        case 'О': outputStr = String.Concat(outputStr, "O"); break;
                        case 'П': outputStr = String.Concat(outputStr, "P"); break;
                        case 'Р': outputStr = String.Concat(outputStr, "R"); break;
                        case 'С': outputStr = String.Concat(outputStr, "S"); break;
                        case 'Т': outputStr = String.Concat(outputStr, "T"); break;
                        case 'У': outputStr = String.Concat(outputStr, "U"); break;
                        case 'Ф': outputStr = String.Concat(outputStr, "F"); break;
                        case 'Х': outputStr = String.Concat(outputStr, "Kh"); break;
                        case 'Ц': outputStr = String.Concat(outputStr, "C"); break;
                        case 'Ч': outputStr = String.Concat(outputStr, "Ch"); break;
                        case 'Ш': outputStr = String.Concat(outputStr, "Sh"); break;
                        case 'Щ': outputStr = String.Concat(outputStr, "Sch"); break;
                        case 'Ъ': break;
                        case 'Ы': outputStr = String.Concat(outputStr, "Y"); break;
                        case 'Ь': break;
                        case 'Э': outputStr = String.Concat(outputStr, "E"); break;
                        case 'Ю': outputStr = String.Concat(outputStr, "Yu"); break;
                        case 'Я': outputStr = String.Concat(outputStr, "Ya"); break;
                        default : outputStr = String.Concat(outputStr, inputStr[i]); break;
                    }
                }
            }

            //makes translit of english text
            if (english == true)
            {
                Console.Write("Translit text : ");
                for (int i = 0; i < inputStr.Length; i++)
                {
                    switch (inputStr[i])
                    {
                        case 'a': outputStr = String.Concat(outputStr, "а"); break;
                        case 'b': outputStr = String.Concat(outputStr, "б"); break;
                        case 'c': outputStr = String.Concat(outputStr, "ц"); break;
                        case 'd': outputStr = String.Concat(outputStr, "д"); break;
                        case 'e': outputStr = String.Concat(outputStr, "е"); break;
                        case 'f': outputStr = String.Concat(outputStr, "ф"); break;
                        case 'g': outputStr = String.Concat(outputStr, "г"); break;
                        case 'h': outputStr = String.Concat(outputStr, "х"); break;
                        case 'i': outputStr = String.Concat(outputStr, "и"); break;
                        case 'j': outputStr = String.Concat(outputStr, "й"); break;
                        case 'k': outputStr = String.Concat(outputStr, "к"); break;
                        case 'l': outputStr = String.Concat(outputStr, "л"); break;
                        case 'm': outputStr = String.Concat(outputStr, "м"); break;
                        case 'n': outputStr = String.Concat(outputStr, "н"); break;
                        case 'o': outputStr = String.Concat(outputStr, "о"); break;
                        case 'p': outputStr = String.Concat(outputStr, "п"); break;
                        case 'q': outputStr = String.Concat(outputStr, "я"); break;
                        case 'r': outputStr = String.Concat(outputStr, "р"); break;
                        case 's': outputStr = String.Concat(outputStr, "с"); break;
                        case 't': outputStr = String.Concat(outputStr, "т"); break;
                        case 'u': outputStr = String.Concat(outputStr, "у"); break;
                        case 'v': outputStr = String.Concat(outputStr, "в"); break;
                        case 'w': outputStr = String.Concat(outputStr, "ш"); break;
                        case 'x': outputStr = String.Concat(outputStr, "х"); break;
                        case 'y': outputStr = String.Concat(outputStr, "ы"); break;
                        case 'z': outputStr = String.Concat(outputStr, "з"); break;
                        case 'A': outputStr = String.Concat(outputStr, "А"); break;
                        case 'B': outputStr = String.Concat(outputStr, "Б"); break;
                        case 'C': outputStr = String.Concat(outputStr, "Ц"); break;
                        case 'D': outputStr = String.Concat(outputStr, "Д"); break;
                        case 'E': outputStr = String.Concat(outputStr, "Е"); break;
                        case 'F': outputStr = String.Concat(outputStr, "Ф"); break;
                        case 'G': outputStr = String.Concat(outputStr, "Г"); break;
                        case 'H': outputStr = String.Concat(outputStr, "Х"); break;
                        case 'I': outputStr = String.Concat(outputStr, "И"); break;
                        case 'J': outputStr = String.Concat(outputStr, "Й"); break;
                        case 'K': outputStr = String.Concat(outputStr, "К"); break;
                        case 'L': outputStr = String.Concat(outputStr, "Л"); break;
                        case 'M': outputStr = String.Concat(outputStr, "М"); break;
                        case 'N': outputStr = String.Concat(outputStr, "Н"); break;
                        case 'O': outputStr = String.Concat(outputStr, "О"); break;
                        case 'P': outputStr = String.Concat(outputStr, "П"); break;
                        case 'Q': outputStr = String.Concat(outputStr, "Я"); break;
                        case 'R': outputStr = String.Concat(outputStr, "Р"); break;
                        case 'S': outputStr = String.Concat(outputStr, "С"); break;
                        case 'T': outputStr = String.Concat(outputStr, "Т"); break;
                        case 'U': outputStr = String.Concat(outputStr, "У"); break;
                        case 'V': outputStr = String.Concat(outputStr, "В"); break;
                        case 'W': outputStr = String.Concat(outputStr, "Ш"); break;
                        case 'X': outputStr = String.Concat(outputStr, "Х"); break;
                        case 'Y': outputStr = String.Concat(outputStr, "Ы"); break;
                        case 'Z': outputStr = String.Concat(outputStr, "З"); break;
                        default: outputStr = String.Concat(outputStr, inputStr[i]); break;
                    }
                }
            }

            //displays the result of translit
            Console.WriteLine(outputStr);
            Console.ReadKey();
        }
    }
}
