using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model
{
    public class Service
    {
        private string _Name;

        public Service(string Name)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                _Name = Name;
            }
        }

        public Service() : this("Не определено") { }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Name = value;
                }
            }
        }
    }
}
