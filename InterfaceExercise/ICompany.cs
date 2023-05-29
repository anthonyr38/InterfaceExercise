using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string CoName { get; set; }
        public int EmpSize { get; set; }
        public int YearEst { get; set; }
    }
}
