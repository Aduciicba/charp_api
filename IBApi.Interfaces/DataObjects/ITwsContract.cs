/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBApi;
using IBApi.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IBApi.Interfaces
{
    /**
     * @class Contract
     * @brief class describing an instrument's definition
     * @sa ContractDetails
     */
    [ComVisible(true)]
    public interface ITwsContract : TWSLib.IContract
    {

        /**
        * @brief The unique contract's identifier
        */
        int ConId { get; set; }

        /**
         * @brief The underlying's asset symbol
         */
        string Symbol { get; set; }

        /**
         * @brief The security's type:
         *      STK - stock
         *      OPT - option
         *      FUT - future
         *      IND - index
         *      FOP - future on an option
         *      CASH - forex pair
         *      BAG - combo
         *      WAR - warrant
         */
        string SecType { get; set; }

        /**
        * @brief The contract's expiration date (i.e. Options and Futures)
        */
        string Expiry { get; set; }

        /**
         * @brief The option's strike price
         */
        double Strike { get; set; }

        /**
         * @brief Either Put or Call (i.e. Options)
         */
        string Right { get; set; }

        /**
         * @brief The instrument's multiplier (i.e. options, futures).
         */
        string Multiplier { get; set; }

        /**
         * @brief The destination exchange.
         */
        string Exchange { get; set; }

        /**
         * @brief The underlying's cuurrency
         */
        string Currency { get; set; }

        /**
         * @brief The contract's symbol within its primary exchange
         */
        string LocalSymbol { get; set; }

        /**
         * @brief The contract's primary exchange.
         */
        string PrimaryExch { get; set; }

        /**
         * @brief The trading class name for this contract.
         * Available in TWS contract description window as well. For example, GBL Dec '13 future's trading class is "FGBL"
         */
        string TradingClass { get; set; }

        /**
        * @brief If set to true, contract details requests and historical data queries can be performed pertaining to expired contracts.
        * Note: Historical data queries on expired contracts are limited to the last year of the contracts life, and are initially only supported for expired futures contracts.
        */
        bool IncludeExpired { get; set; }

        /**
         * @brief Security's identifier when querying contract's details or placing orders
         *      SIN - Example: Apple: US0378331005
         *      CUSIP - Example: Apple: 037833100
         *      SEDOL - Consists of 6-AN + check digit. Example: BAE: 0263494
         *      RIC - Consists of exchange-independent RIC Root and a suffix identifying the exchange. Example: AAPL.O for Apple on NASDAQ.
         */
        string SecIdType { get; set; }

        /**
        * @brief Identifier of the security type
        * @sa secIdType
        */
        string SecId { get; set; }

        /**
        * @brief Description of the combo legs.
        */
        string ComboLegsDescription { get; set; }

        /**
         * @brief The legs of a combined contract definition
         * @sa ComboLeg
         */
        List<ITwsComboLeg> ComboLegs { get; set; }

        /**
         * @brief Delta and underlying price for Delta-Neutral combo orders.
         * Underlying (STK or FUT), delta and underlying price goes into this attribute.
         * @sa UnderComp
         */
        ITwsUnderComp UnderComp { get; set; }

        
    }
}
