using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAnyObject
{
    class SortBase
    {
        public virtual bool SortArray(object[] array)
        {
            if (array != null)
            {
                return true;
            }
            return false;
        }
    }
}
