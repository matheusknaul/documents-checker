using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum CancellationReason
    {
        Sucess,
        Error,
        Timeout,
        UserCancelled,
        Undefined
    }
}
