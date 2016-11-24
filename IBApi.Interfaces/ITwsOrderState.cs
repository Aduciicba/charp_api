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
     * @class OrderState
     * @brief Provides an active order's current state
     * @sa Order
     */
    [ComVisible(true)]
    public interface ITwsOrderState 
    {
        /**
         * @brief The order's current status
         */
        string Status{ get; set; }

        /**
         * @brief The order's impact on the account's initial margin.
         */
        string InitMargin{ get; set; }

        /**
        * @brief The order's impact on the account's maintenance margin
        */
        string MaintMargin{ get; set; }

        /**
        * @brief Shows the impact the order would have on the account's equity with loan
        */
        string EquityWithLoan{ get; set; }

        /**
          * @brief The order's generated commission.
          */
        double Commission{ get; set; }

        /**
        * @brief The execution's minimum commission.
        */
        double MinCommission{ get; set; }

        /**
        * @brief The executions maximum commission.
        */
        double MaxCommission{ get; set; }

        /**
         * @brief The generated commission currency
         * @sa CommissionReport
         */
        string CommissionCurrency{ get; set; }

        /**
         * @brief If the order is warranted, a descriptive message will be provided.
         */
        string WarningText{ get; set; }

    }
}
