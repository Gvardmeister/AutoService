using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model
{
    public class CarService : Service
    {
        private int _Index;
        private int _Time;

        public CarService(int Index, int Time)
        {
            if(Index >= 0)
            {
                _Index = Index;
            }

            if (Time > 0)
            {
                _Time = Time;
            }
        }

        public CarService() : this(0, 1) { }

        public int Time
        {
            get
            {
                return _Time;
            }

            set
            {
                if (value > 0)
                {
                    _Time = value;
                }
            }
        }

        public int Index
        {
            get
            {
                return _Index;
            }

            set
            {
                if (value > 0)
                {
                    _Index = value;
                }
            }
        }
    }
}
