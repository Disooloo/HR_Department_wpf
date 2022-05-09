using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HR_Department.db;
using System.Threading.Tasks;

namespace HR_Department.actions
{
    class customVacancu : vacancy
    {
        public customVacancu(vacancy vac)
        {
            id = vac.id;
            titleVacancy = vac.titleVacancy;
        }
    }
}
