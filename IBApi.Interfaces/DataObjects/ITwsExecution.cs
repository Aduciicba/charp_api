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
     * @class Execution
     * @brief Class describing an order's execution.
     * @sa ExecutionFilter, CommissionReport
     */
    [ComVisible(true)]
    public interface ITwsExecution : TWSLib.IExecution
    {
        /**
         * @brief The API client's order Id.
         */
        int OrderId { get; set; }

        /**
         * @brief The API client identifier which placed the order which originated this execution.
         */
        int ClientId { get; set; }

        /**
         * @brief The execution's identifier.
         */
        string ExecId { get; set; }

        /**
         * @brief The execution's server time.
         */
        string Time { get; set; }

        /**
         * @brief The account to which the order was allocated.
         */
        string AcctNumber { get; set; }

        /**
         * @brief The exchange where the execution took place.
         */
        string Exchange { get; set; }

        /**
         * @brief Specifies if the transaction was buy or sale
         * BOT for bought, SLD for sold
         */
        string Side { get; set; }

        /**
         * @brief The number of shares filled.
         */
        int Shares { get; set; }

        /**
         * @brief The order's execution price excluding commissions.
         */
        double Price { get; set; }

        /**
         * @brief The TWS order identifier.
         */
        int PermId { get; set; }

        /**
         * @brief Identifies the position as one to be liquidated last should the need arise.
         */
        int Liquidation { get; set; }

        /**
         * @brief Cumulative quantity. 
         * Used in regular trades, combo trades and legs of the combo.
         */
        int CumQty { get; set; }

        /**
         * @brief Average price. 
         * Used in regular trades, combo trades and legs of the combo. Includes commissions.
         */
        double AvgPrice { get; set; }

        /**
         * @brief Allows API client to add a reference to an order.
         */
        string OrderRef { get; set; }

        /**
         * @brief The Economic Value Rule name and the respective optional argument.
         * The two values should be separated by a colon. For example, aussieBond:YearsToExpiration=3. When the optional argument is not present, the first value will be followed by a colon.
         */
        string EvRule { get; set; }

        /**
         * @brief Tells you approximately how much the market value of a contract would change if the price were to change by 1.
         * It cannot be used to get market value by multiplying the price by the approximate multiplier.
         */
        double EvMultiplier { get; set; }

        
    }
}
