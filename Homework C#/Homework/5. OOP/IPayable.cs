using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    interface IPayable
    {
        double getPaymentAmount(int numberOfWeeks);
    }
}
