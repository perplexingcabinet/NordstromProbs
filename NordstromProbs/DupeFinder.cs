using NordstromProbs.Tests.Unit;
using System.Collections.Generic;

namespace NordstromProbs
{
    public class DupeFinder : IDupeFinder
    {
        public int FindDupe(int[] intArr)
        {
            var foundNumbers = new Dictionary<int,int>();
            for (var i = 0; i < intArr.Length; i++)
            {
                if (foundNumbers.ContainsKey(intArr[i]))
                {
                    return intArr[i];
                }
                foundNumbers.Add(intArr[i], i);
            }
            return -1;
        }
    }
}