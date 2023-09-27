using MyBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Paging
{
    public class PagingPerformance<T>
    {
        public List<T> eI_TEST_PERFORMANCEs=new List<T>();
        public bool HasNext;
        public bool HasPravious;
    }
}
