using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCardsShuffle.Extensions
{
    public static class MyListExtension
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> values)
        {
            List<T> randomizedList = new List<T>();
            List<T> list = new List<T>(values.ToList());

            Random rnd = new Random();
            while (list.Count > 0)
            {
                int index = rnd.Next(0, list.Count);
                randomizedList.Add(list[index]);
                list.RemoveAt(index);
            }
            return randomizedList;
        }

    }
}
