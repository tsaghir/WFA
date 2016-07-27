using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.BAL
{
    public class GetData
    {
        /// <summary>
        /// Method for getting all the workers in the hospital
        /// </summary>
        /// <returns></returns>
        public IEnumerable<djelatnici> GetDjelatnici()
        {
            djelatniciDAL dj = new djelatniciDAL();
            return dj.ReadDjelatnici();
        }
    }
}
