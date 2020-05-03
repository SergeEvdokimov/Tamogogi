using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamogochi
{
    class scale
    {
        public int Cur;
        public int Max;
        public scale()
        {
            Cur = 0;
            Max = 0;
        }
        public scale(int _Cur)
        {
            Cur = _Cur;
            Max = 100;
        }
        public scale(int _Cur, int _Max)
        {
            Cur = _Cur;
            Max = _Max;
        }
    }
}
