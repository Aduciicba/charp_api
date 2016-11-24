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
     * @class OrderComboLeg
     * @brief Allows to specify a price on an order's leg
     * @sa Order, ComboLeg
     */
    [ComVisible(true)]
    public interface ITwsOrderComboLeg 
    {

        /**
         * @brief The order's leg's price
         */
        double Price{ get; set; }

       
    }
}
