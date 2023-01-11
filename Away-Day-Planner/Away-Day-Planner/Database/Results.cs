using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Database
{
    internal class Results : IResults
    {
        public static IResults Empty = NullResults();

        public int Size { private set; get; }

        private IList results;

        private static Results NullResults()
        {
            Results _null = new Results();
            int _size = 0;
            _null.SetResultsSize(_size);
            return _null;
        }

        public Results(){}

        public Results(IList resultList)
        {
            SetResults(resultList);
        }

        public void AddToResults<T>(T obj)
        {
            Console.WriteLine(obj.ToString());
            results.Add(obj);
        }

        public void RemoveFromResults<T>(T obj)
        {
            results.Remove(obj);
        }

        public void SetResults(IList list)
        {
            results = list;
            SetResultsSize(results.Count);
        }

        public void SetResultsSize(int size)
        {
            this.Size = size;
        }

        public IList GetList()
        {
            return results;
        }
    }
}
