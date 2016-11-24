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
     * @class ContractDetails
     * @brief extended contract details.
     * @sa Contract
     */
    [ComVisible(true)]
    public interface ITwsContractDetails 
    {

        /**
         * @brief A Contract object summarising this product.
         */
        Contract Summary { get; set; }

        /**
        * @brief The market name for this product.
        */
        string MarketName { get; set; }

        /**
        * @brief The minimum allowed price variation.
         * Note that many securities vary their minimum tick size according to their price. This value will only show the smallest of the different minimum tick sizes regardless of the product's price.
        */
        double MinTick { get; set; }

        /**
        * @brief Allows execution and strike prices to be reported consistently with market data, historical data and the order price, i.e. Z on LIFFE is reported in Index points and not GBP.
        */
        int PriceMagnifier { get; set; }

        /**
        * @brief Supported order types for this product.
        */
        string OrderTypes { get; set; }

        /**
        * @brief Exchanges on which this product is traded.
        */
        string ValidExchanges { get; set; }

        /**
        * @brief Underlying's contract Id
        */
        int UnderConId { get; set; }

        /**
        * @brief Descriptive name of the product.
        */
        string LongName { get; set; }

        /**
        * @brief Typically the contract month of the underlying for a Future contract.
        */
        string ContractMonth { get; set; }

        /**
        * @brief The industry classification of the underlying/product. For example, Financial.
        */
        string Industry { get; set; }

        /**
        * @brief The industry category of the underlying. For example, InvestmentSvc.
        */
        string Category { get; set; }

        /**
        * @brief The industry subcategory of the underlying. For example, Brokerage.
        */
        string Subcategory { get; set; }

        /**
        * @brief The ID of the time zone for the trading hours of the product. For example, EST.
        */
        string TimeZoneId { get; set; }

        /**
        * @brief The trading hours of the product.
         * This value will contain the trading hours of the current day as well as the next's. For example, 20090507:0700-1830,1830-2330;20090508:CLOSED.
        */
        string TradingHours { get; set; }

        /**
        * @brief The liquid hours of the product.
         * This value will contain the liquid hours of the current day as well as the next's. For example, 20090507:0700-1830,1830-2330;20090508:CLOSED.
        */
        string LiquidHours { get; set; }

        /**
        * @brief Contains the Economic Value Rule name and the respective optional argument.
         * The two values should be separated by a colon. For example, aussieBond:YearsToExpiration=3. When the optional argument is not present, the first value will be followed by a colon.
        */
        string EvRule { get; set; }

        /**
        * @brief Tells you approximately how much the market value of a contract would change if the price were to change by 1. 
         * It cannot be used to get market value by multiplying the price by the approximate multiplier.
        */
        double EvMultiplier { get; set; }

        /**
        * @brief A list of contract identifiers that the customer is allowed to view.
         * CUSIP/ISIN/etc.
        */
        List<TagValue> SecIdList { get; set; }

        /**
        * @brief The nine-character bond CUSIP or the 12-character SEDOL.
         * For Bonds only.
        */
        string Cusip { get; set; }

        /**
        * @brief Identifies the credit rating of the issuer.
         * For Bonds only. A higher credit rating generally indicates a less risky investment. Bond ratings are from Moody's and S&P respectively.
        */
        string Ratings { get; set; }

        /**
        * @brief A description string containing further descriptive information about the bond.
         * For Bonds only.
        */
        string DescAppend { get; set; }

        /**
        * @brief The type of bond, such as "CORP."
        */
        string BondType { get; set; }

        /**
        * @brief The type of bond coupon.
         * For Bonds only.
        */
        string CouponType { get; set; }

        /**
        * @brief If true, the bond can be called by the issuer under certain conditions.
         * For Bonds only.
        */
        bool Callable { get; set; }

        /**
        * @brief Values are True or False. If true, the bond can be sold back to the issuer under certain conditions.
         * For Bonds only.
        */
        bool Putable { get; set; }

        /**
        * @brief The interest rate used to calculate the amount you will receive in interest payments over the course of the year.
         * For Bonds only.
        */
        double Coupon { get; set; }

        /**
        * @brief Values are True or False. If true, the bond can be converted to stock under certain conditions.
         * For Bonds only.
        */
        bool Convertible { get; set; }

        /**
        * @brief he date on which the issuer must repay the face value of the bond.
         * For Bonds only.
        */
        string Maturity { get; set; }

        /** 
        * @brief The date the bond was issued. 
         * For Bonds only.
        */
        string IssueDate { get; set; }

        /**
        * @brief Only if bond has embedded options. 
         * Refers to callable bonds and puttable bonds. Available in TWS description window for bonds.
        */
        string NextOptionDate { get; set; }

        /**
        * @brief Type of embedded option.
        * Only if bond has embedded options.
        */
        string NextOptionType { get; set; }

        /**
       * @brief Only if bond has embedded options.
        * For Bonds only.
       */
        bool NextOptionPartial { get; set; }

        /**
        * @brief If populated for the bond in IB's database.
         * For Bonds only.
        */
        string Notes { get; set; }

        
    }
}
