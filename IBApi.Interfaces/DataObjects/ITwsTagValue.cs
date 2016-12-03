/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBApi.TWSApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IBApi.Interfaces
{
    [ComVisible(true)]
    public interface ITwsTagValue : TWSApi.ITagValue
    {
        string Tag{ get; set; }        

        string Value{ get; set; }

        
    }
}
