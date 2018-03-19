using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetzwerkLib
{
    public enum Commands: uint
    {
        None,
        SendMsg,
        SendPMsg,
        GetName,
        SetName,
        Disconnect,

    }
}
