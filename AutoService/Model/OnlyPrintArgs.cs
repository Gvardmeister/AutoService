using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model
{
    // Делегат для передачи метода для события
    public delegate void CalcBack(string s);

    // Класс параметров
    public class OnlyPrintArgs : EventArgs
    {
        public CalcBack PrintResult;
        public Manager Manager;
    }
}
