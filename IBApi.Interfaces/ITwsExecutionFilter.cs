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
     * @class ExecutionFilter
     * @brief when requesting executions, a filter can be specified to receive only a subset of them
     * @sa Contract, Execution, CommissionReport
     */
    [ComVisible(true)]
    public interface ITwsExecutionFilter 
    {
        
        /**
         * @brief The API client which placed the order
         */
        int ClientId { get; set; }

        /**
        * @brief The account to which the order was allocated to
        */
        string AcctCode { get; set; }

        /**
         * @brief Time from which the executions will be brough yyyymmdd hh:mm:ss
         * Only those executions reported after the specified time will be returned.
         */
        string Time { get; set; }

        /**
        * @brief The instrument's symbol
        */
        string Symbol { get; set; }

        /**
         * @brief The Contract's security's type (i.e. STK, OPT...)
         */
        string SecType { get; set; }

        /**
         * @brief The exchange at which the execution was produced
         */
        string Exchange { get; set; }

        /**
        * @brief The Contract's side (Put or Call).
        */
        string Side { get; set; }

        
    }
}
