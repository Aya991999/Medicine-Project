using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.TopWave
{
    public class PagingParameterViewModel
    {
        public int max_PageSize = 100;
        public int _PageIndex { get; set; } = 1;
        public int _PageSize = 10;
        public int PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {

                _PageSize = (value > max_PageSize) ? max_PageSize : value;
            }
        }
        public bool? ASC { get; set; } = null;

        public string? param { get; set; }=null;
        public object? obj { get; set; } = null;
    }
}
