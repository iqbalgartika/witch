using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekseatWitch.Models
{
    public class WitchAlgorithm
    {
        //cache
        private static readonly List<int> sumList = new List<int> { 0, 1 };
        private static readonly List<int> fibo = new List<int> { 0, 1 };

        private static int TotalKill (int year)
        {
            if (year < 0)
            {
                return -1;
            }
            //check cache first
            if(sumList.Count > year)
            {
                return sumList[year];
            }

            int sum = sumList.Last();

            for (int i = sumList.Count; i <= year; i++)
            {
                fibo.Add(fibo[i - 2] + fibo[i - 1]);
                sum += fibo[i];
                sumList.Add(sum);
            }

            return sum;
        }

        public static decimal AvgKills (List<Villager> villagers)
        {
            try
            {
                decimal total = 0;
                villagers.ForEach(villager =>
                {
                    total += TotalKill(villager.YearofBirth);
                });
                return total/villagers.Count;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
