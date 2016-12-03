/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IBApi.Interfaces
{
    /**
     * @brief Delta-Neutral Underlying Component.
     */
    [ComVisible(true)]
    public interface ITwsUnderComp : TWSLib.IUnderComp
    {
        /**
         * @brief
         */
        int ConId{ get; set; }

        /**
        * @brief
        */
        double Delta{ get; set; }

        /**
        * @brief
        */
        double Price{ get; set; }

    }
}
