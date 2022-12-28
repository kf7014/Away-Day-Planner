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

        public int size { private set; get; }

        private ArrayList results = new ArrayList();

        private static Results NullResults()
        {
            Results   _null    = new Results();
            ArrayList _results = new ArrayList();
            int       _size    = _results.Count;

            _null.SetResultsSize(_size);
            _null.SetResults(_results);

            return _null;
        }

        public void AddToResults<T>(T obj)
        {
            results.Add(obj);
        }

        public void RemoveFromResults<T>(T obj)
        {
            results.Remove(obj);
        }

        public void SetResults(IList list)
        {
            results = (ArrayList)list;
            SetResultsSize(results.Count);
        }

        public void SetResultsSize(int size)
        {
            this.size = size;
        }

        public IList GetList()
        {
            return results;
        }
    }
}
