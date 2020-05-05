using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c4_p1_b1
{
    class classTinh
    {
        public int tinhTongg(int m,int n)
        {
            int tong = 0;
                for(int i=m; i<=n;i++)
                {
                    tong = tong + i;
                }
            return tong;
        }
    }
}
