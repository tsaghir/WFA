using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;

namespace HouseMed.BAL
{
    public class ZdravUstanovaBAL
    {
        #region private variables
        private ZdravUstanovaDAL _zdravUstanova;
        #endregion

        #region constructor
        public ZdravUstanovaBAL()
        {
            _zdravUstanova = new ZdravUstanovaDAL();
        }
        #endregion

        #region public methods
        public IEnumerable<sifra_zdrv_ustanove> GetAllUstanove()
        {
            return _zdravUstanova.GetAllUstanove();
        }
        #endregion
    }
}
