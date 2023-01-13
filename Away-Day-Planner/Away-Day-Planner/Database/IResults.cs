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
