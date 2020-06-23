using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeeklyContest193
{
    class RunningSumClass
    {
        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];
            runningSum[0] = nums[0];
            for(int i=1; i<nums.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + nums[i];
            }
            return runningSum;
        }
    }

    class LeastNumber
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            var numberCountDict = new Dictionary<int, int>();
            foreach(int i in arr)
            {
                numberCountDict[i] = numberCountDict.GetValueOrDefault(i, 0) + 1;
            }
            var Keys = numberCountDict.OrderBy(x => x.Value);
            int count = 0;
            int currentK = 0;
            foreach(var i in Keys)
            {
                if(numberCountDict[i.Key]+currentK <= k)
                {
                    currentK += numberCountDict[i.Key];
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
    }
}
