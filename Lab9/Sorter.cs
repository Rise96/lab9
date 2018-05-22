using System.Collections.Generic;
using System.Linq;

namespace Lab9
{
    class Sorter
    {
        public List<List<int>> Sort(List<List<int>> array)
        {
            int k = FindColumnWithMax(array);
            for(int i = 0; i < array.Count(); i++)
            {
                for(int j = i; j < array.Count(); j++)
                {
                    if (array[j][k] < array[i][k])
                    {
                        array.Insert(i, array[j]);
                        array.RemoveAt(j+1);
                    }
                }
            }
            return array;
        }
        private int FindColumnWithMax(List<List<int>> array)
        {
            int maxIndex = 0;
            int max = array[0][0];
            for(int i = 0; i < array.Count; i++)
            {
                for(int j = 0; j < array[i].Count; j++)
                {
                    if (array[i][j] > max)
                    {
                        max = array[i][j];
                        maxIndex = j;
                    }
                }
            }
            return maxIndex;
        }
    }
}
