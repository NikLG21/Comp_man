using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using Common.Model.Enum;

namespace Common.Extensions
{
    public static class HackingTasksExtensions
    {
        private static Random rng = new Random();
        
        public static void Shuffle<T>(this IList<HackingTask> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                HackingTask value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
