using System.Collections.Generic;

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

            // create a list of indexes where points stand
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

            //looking for points that are not farther than 4 positions apart
                        for (int i = 2; i < countOfPoints; i++)
            {
                //differenceBetween1And2Points
                int diff1 = pointIndices[i] - pointIndices[i - 1];
                //differenceBetween2And3Points
                int diff2 = pointIndices[i - 1] - pointIndices[i - 2];

                if (diff1 <= 4 && diff2 <= 4)
                {
                    string estimatedIp = sequenceOfCharacters.Substring(pointIndices[i - 2] - 3, 7 + diff1 + diff2);
                    sequencesSimilarToIp.Add(estimatedIp);
                }
            }
            return sequencesSimilarToIp;
        }

    }
}
