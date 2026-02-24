using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class clsPeople
    {

        public static DataTable GetPeopleData()
        {
            return clsPeopleData.GetPeopleData();
        }

    }
}
