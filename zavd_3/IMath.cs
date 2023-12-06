using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    interface IMath
    {
        int Max();

        int Min();

        double Avg();

        bool Search(int valueToSearch);
    }
}
