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
     * @class ScannerSubscription
     * @brief Defines a market scanner request
     */
    [ComVisible(true)]
    public interface ITwsScannerSubscription 
    {
        /**
         * @var int numberOfRows
         * @brief The number of rows to be returned for the query
         */
        int NumberOfRows{ get; set; }

        /**
         * @var string instrument
         * @brief The instrument's type for the scan. I.e. STK, FUT.HK, etc.
         */
        string Instrument{ get; set; }

        /**
         * @var string locationCode
         * @brief The request's location (STK.US, STK.US.MAJOR, etc). 
         */
        string LocationCode{ get; set; }

        /**
         * @var string scanCode
         * @brief Same as TWS Market Scanner's "parameters" field, for example: TOP_PERC_GAIN
         */
        string ScanCode{ get; set; }

        /**
         * @var double abovePrice
         * @brief Filters out Contracts which price is below this value
         */
        double AbovePrice{ get; set; }

        /**
         * @var double belowPrice
         * @brief Filters out contracts which price is above this value.
         */
        double BelowPrice{ get; set; }

        /**
         * @var int aboveVolume
         * @brief Filters out Contracts which volume is above this value.
         */
        int AboveVolume{ get; set; }

        /**
         * @var int averageOptionVolumeAbove
         * @brief Filters out Contracts which option volume is above this value.
         */
        int AverageOptionVolumeAbove{ get; set; }

        /**
        * @var double marketCapAbove
        * @brief Filters out Contracts which market cap is above this value.
        */
        double MarketCapAbove{ get; set; }

        /**
         * @var double marketCapBelow
         * @brief Filters out Contracts which market cap is below this value.
         */
        double MarketCapBelow{ get; set; }

        /**
         * @var string moodyRatingAbove
         * @brief Filters out Contracts which Moody's rating is below this value.
         */
        string MoodyRatingAbove{ get; set; }

        /**
        * @var string moodyRatingBelow
        * @brief Filters out Contracts which Moody's rating is above this value.
        */
        string MoodyRatingBelow{ get; set; }

        /**
         * @var string spRatingAbove
         * @brief Filters out Contracts with a S&P rating below this value.
         */
        string SpRatingAbove{ get; set; }

        /**
         * @var string spRatingBelow
         * @brief Filters out Contracts with a S&P rating above this value.
         */
        string SpRatingBelow{ get; set; }

        /**
         * @var string maturityDateAbove
         * @brief Filter out Contracts with a maturity date earlier than this value.
         */
        string MaturityDateAbove{ get; set; }

        /**
         * @var string maturityDateBelow
         * @brief Filter out Contracts with a maturity date older than this value.
         */
        string MaturityDateBelow{ get; set; }

        /**
         * @var double couponRateAbove
         * @brief Filter out Contracts with a coupon rate lower than this value.
         */
        double CouponRateAbove{ get; set; }

        /**
         * @var double couponRateBelow
         * @brief Filter out Contracts with a coupon rate higher than this value.
         */
        double CouponRateBelow{ get; set; }

        /**
         * @var string excludeConvertible
         * @brief Filters out Convertible bonds
         */
        string ExcludeConvertible{ get; set; }

        /**
         * @var string scannerSettingPairs
         * @brief For example, a pairing "Annual, true" used on the "top Option Implied Vol % Gainers" scan would return annualized volatilities.
         */
        string ScannerSettingPairs{ get; set; }

        /**
         * @var string stockTypeFilter
         * @brief -
         *      CORP = Corporation
         *      ADR = American Depositary Receipt
         *      ETF = Exchange Traded Fund
         *      REIT = Real Estate Investment Trust
         *      CEF = Closed End Fund
         */
        string StockTypeFilter{ get; set; }


    }
}
