/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Database
{
    public class Results : IResults
    {
        //Null Object if a results object is created but no results actually added
        public static Results Empty = NullResults();

        // Size of the results object (How many results it is currently storing)
        public int Size { private set; get; }
        int IResults.Size { get; set; }

        // List of results
        private IList results;

        // Creation of the null object with nothing added to it
        private static Results NullResults()
        {
            Results _null = new Results();
            int _size = 0;
            _null.SetResultsSize(_size);
            return _null;
        }

        private Results(){}

        // Constructor, allows for a result object to be created with a list straight away
        public Results(IList resultList)
        {
            SetResults(resultList);
        }

        // Add an individual result to the list
        public void AddToResults<T>(T obj)
        {
            Console.WriteLine(obj.ToString());
            results.Add(obj);
        }

        // Remove a single result from the list
        public void RemoveFromResults<T>(T obj)
        {
            results.Remove(obj);
        }

        // Sets the results list from a list
        public void SetResults(IList list)
        {
            results = list;
            SetResultsSize(results.Count);
        }

        // Sets the size od the result object to the size passed to it (List.Count)
        public void SetResultsSize(int size)
        {
            this.Size = size;
        }
        // Returns the result list
        public IList GetList()
        {
            return results;
        }

        // Returns the list as queryable
        public IQueryable AsQueryable()
        {
            return results.AsQueryable();
        }

        // List is lareadt Enumerable, not implemented. (Added to comply with interface)
        public IEnumerable AsEnumerable()
        {
            throw new NotImplementedException();
        }
    }
}
