using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class IP
    {
        public List<string> FindSequencesSimilarToIp(string sequenceOfCharacters)
        {
            List<string> sequencesSimilarToIp = new List<string>();
            List<int> pointIndices = new List<int>();
            int ind = -1;
            int numberOfCharacters = sequenceOfCharacters.Length;
            int startIndex = 0;
            while (startIndex <= numberOfCharacters)
            {
                ind = sequenceOfCharacters.IndexOf(".", startIndex);
                if (ind >= 0)
                {
                    pointIndices.Add(ind);
                    ind++;
                    startIndex = ind + 1;
                }
                else break;
            }

            int countOfPoints = 0;
            foreach (var item in pointIndices)
            {
                countOfPoints++;
            }

            for (int i = 0; i < countOfPoints - 3; i++)
            {
                if ((pointIndices[i + 3] - pointIndices[i + 2] > 1 && pointIndices[i + 3] - pointIndices[i + 2] < 5) && 
                    (pointIndices[i + 2] - pointIndices[i + 1] > 1 && pointIndices[i + 2] - pointIndices[i + 1] < 5) &&
                    (pointIndices[i + 1] - pointIndices[i] > 1 && pointIndices[i + 1] - pointIndices[i] < 5))
                {
                    string estimatedIp = sequenceOfCharacters.Substring(pointIndices[i - 3], pointIndices[i+3]- pointIndices[i] + 3);
                    sequencesSimilarToIp.Add(estimatedIp);
                }

            }

            return sequencesSimilarToIp;
        }

    }
}
