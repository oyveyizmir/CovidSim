using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSimApp.Model2D
{
    interface ISavable
    {
        void ValidateAndSave(bool save = true);
    }
}
