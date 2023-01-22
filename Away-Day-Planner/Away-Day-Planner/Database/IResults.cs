/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
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
using System.Windows.Forms.VisualStyles;

namespace Away_Day_Planner.Database
{
    // Used to return a list of results with some added functionality
    public interface IResults
    {
        int Size { set; get; }
        
        void SetResults(IList objs);
        void AddToResults<T>(T obj);
        void RemoveFromResults<T>(T obj);
        void SetResultsSize(int size);
        IList GetList();
        IQueryable AsQueryable();
        IEnumerable AsEnumerable();
    }
}
