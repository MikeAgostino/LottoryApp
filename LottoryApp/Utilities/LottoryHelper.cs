using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LottoryApp.Utilities
{
    public static class LottoryHelper
    {
        public static string GenerateNumbers(int lowerLimit,int upperLimit, int totalNumbers, int totalBonusNumbers,int bonusLowerLimit,int bonusupperLimit)
        {
            string numbers = "";
            int totalNumCount = 0;
            List<int> numlist = new List<int>(0);
            Random randomNum = new Random();
            while (totalNumCount < totalNumbers)
            {
                var newNum = randomNum.Next(lowerLimit, upperLimit + 1);
                while (numlist.Contains(newNum))
                {
                    newNum = randomNum.Next(lowerLimit, upperLimit + 1);
                }
                numlist.Add(newNum);
                totalNumCount++;
            }
            numlist.Sort();
            foreach(var num in numlist)
            {
                numbers += num + ", ";
            }
            numbers = numbers.Substring(0, numbers.Length -2);

            return numbers;
        }
    }
}