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
     * @class Order
     * @brief The order's description.
     * @sa Contract, OrderComboLeg, OrderState
     */
    [ComVisible(true)]
    public interface ITwsOrder 
    {
        /**
         * @brief The API client's order id.
         */
        int OrderId{ get; set; }

        /**
         * @brief The API client id which placed the order.
         */
        int ClientId{ get; set; }

        /**
         * @brief The Host order identifier.
         */
        int PermId{ get; set; }

        /**
         * @brief Identifies the side.
         * Possible values are BUY, SELL, SSHORT
         */
        string Action{ get; set; }

        /**
         * @brief The number of positions being bought/sold.
         */
        int TotalQuantity{ get; set; }

        /**
         * @brief The order's type.
         * Available Orders are at https://www.interactivebrokers.com/en/software/api/apiguide/tables/supported_order_types.htm 
         */
        string OrderType{ get; set; }

        /**
         * @brief The LIMIT price.
         * Used for limit, stop-limit and relative orders. In all other cases specify zero. For relative orders with no limit price, also specify zero.
         */
        double LmtPrice{ get; set; }

        /**
         * @brief Generic field to contain the stop price for STP LMT orders, trailing amount, etc.
         */
        double AuxPrice{ get; set; }

        /**
          * @brief The time in force.
         * Valid values are: \n
         *      DAY - Valid for the day only.\n
         *      GTC - Good until canceled. The order will continue to work within the system and in the marketplace until it executes or is canceled. GTC orders will be automatically be cancelled under the following conditions:
         *          \t\t If a corporate action on a security results in a stock split (forward or reverse), exchange for shares, or distribution of shares.
         *          \t\t If you do not log into your IB account for 90 days.\n
         *          \t\t At the end of the calendar quarter following the current quarter. For example, an order placed during the third quarter of 2011 will be canceled at the end of the first quarter of 2012. If the last day is a non-trading day, the cancellation will occur at the close of the final trading day of that quarter. For example, if the last day of the quarter is Sunday, the orders will be cancelled on the preceding Friday.\n
         *          \t\t Orders that are modified will be assigned a new “Auto Expire” date consistent with the end of the calendar quarter following the current quarter.\n
         *          \t\t Orders submitted to IB that remain in force for more than one day will not be reduced for dividends. To allow adjustment to your order price on ex-dividend date, consider using a Good-Til-Date/Time (GTD) or Good-after-Time/Date (GAT) order type, or a combination of the two.\n
         *      IOC - Immediate or Cancel. Any portion that is not filled as soon as it becomes available in the market is canceled.\n
         *      GTD. - Good until Date. It will remain working within the system and in the marketplace until it executes or until the close of the market on the date specified\n
         *      OPG - Use OPG to send a market-on-open (MOO) or limit-on-open (LOO) order.\n
         *      FOK - If the entire Fill-or-Kill order does not execute as soon as it becomes available, the entire order is canceled.\n
         *      DTC - Day until Canceled \n
          */
        string Tif{ get; set; }


        /**
         * @brief One-Cancels-All group identifier.
         */
        string OcaGroup{ get; set; }

        /**
         * @brief Tells how to handle remaining orders in an OCA group when one order or part of an order executes.
         * Valid values are:\n
         *      \t\t 1 = Cancel all remaining orders with block.\n
         *      \t\t 2 = Remaining orders are proportionately reduced in size with block.\n
         *      \t\t 3 = Remaining orders are proportionately reduced in size with no block.\n
         * If you use a value "with block" gives your order has overfill protection. This means that only one order in the group will be routed at a time to remove the possibility of an overfill.
         */
        int OcaType{ get; set; }

        /**
         * @brief The order reference.
         * Intended for institutional customers only, although all customers may use it to identify the API client that sent the order when multiple API clients are running.
         */
        string OrderRef{ get; set; }

        /**
         * @brief Specifies whether the order will be transmitted by TWS. If set to false, the order will be created at TWS but will not be sent.
         */
        bool Transmit{ get; set; }

        /**
         * @brief The order ID of the parent order, used for bracket and auto trailing stop orders.
         */
        int ParentId{ get; set; }

        /**
         * @brief If set to true, specifies that the order is an ISE Block order.
         */
        bool BlockOrder{ get; set; }

        /**
         * @brief If set to true, specifies that the order is a Sweep-to-Fill order.
         */
        bool SweepToFill{ get; set; }

        /**
         * @brief The publicly disclosed order size, used when placing Iceberg orders.
         */
        int DisplaySize{ get; set; }

        /**
         * @brief Specifies how Simulated Stop, Stop-Limit and Trailing Stop orders are triggered.
         * Valid values are:\n
         *  0 - The default value. The "double bid/ask" function will be used for orders for OTC stocks and US options. All other orders will used the "last" function.\n
         *  1 - use "double bid/ask" function, where stop orders are triggered based on two consecutive bid or ask prices.\n
         *  2 - "last" function, where stop orders are triggered based on the last price.\n
         *  3 double last function.\n
         *  4 bid/ask function.\n
         *  7 last or bid/ask function.\n
         *  8 mid-point function.\n
         */
        int TriggerMethod{ get; set; }

        /**
         * @brief If set to true, allows orders to also trigger or fill outside of regular trading hours.
         */
        bool OutsideRth{ get; set; }

        /**
         * @brief If set to true, the order will not be visible when viewing the market depth. 
         * This option only applies to orders routed to the ISLAND exchange.
         */
        bool Hidden{ get; set; }

        /**
         * @brief Specifies the date and time after which the order will be active.
         * Format: yyyymmdd hh:mm:ss {optional Timezone}
         */
        string GoodAfterTime{ get; set; }

        /**
         * @brief The date and time until the order will be active.
         * You must enter GTD as the time in force to use this string. The trade's "Good Till Date," format "YYYYMMDD hh:mm:ss (optional time zone)"
         */
        string GoodTillDate{ get; set; }

        /**
         * @brief Overrides TWS constraints.
         * Precautionary constraints are defined on the TWS Presets page, and help ensure tha tyour price and size order values are reasonable. Orders sent from the API are also validated against these safety constraints, and may be rejected if any constraint is violated. To override validation, set this parameter’s value to True.
         * 
         */
        bool OverridePercentageConstraints{ get; set; }

        /**
         * @brief -
         * Individual = 'I'\n
         * Agency = 'A'\n
         * AgentOtherMember = 'W'\n
         * IndividualPTIA = 'J'\n
         * AgencyPTIA = 'U'\n
         * AgentOtherMemberPTIA = 'M'\n
         * IndividualPT = 'K'\n
         * AgencyPT = 'Y'\n
         * AgentOtherMemberPT = 'N'\n
         */
        string Rule80A{ get; set; }

        /**
         * @brief Indicates whether or not all the order has to be filled on a single execution.
         */
        bool AllOrNone{ get; set; }

        /**
         * @brief Identifies a minimum quantity order type.
         */
        int MinQty{ get; set; }

        /**
         * @brief The percent offset amount for relative orders.
         */
        double PercentOffset{ get; set; }

        /**
         * @brief Trail stop price for TRAILIMIT orders.
         */
        double TrailStopPrice{ get; set; }

        /**
         * @brief Specifies the trailing amount of a trailing stop order as a percentage.
         * Observe the following guidelines when using the trailingPercent field:\n
         *    - This field is mutually exclusive with the existing trailing amount. That is, the API client can send one or the other but not both.\n
         *    - This field is read AFTER the stop price (barrier price) as follows: deltaNeutralAuxPrice stopPrice, trailingPercent, scale order attributes\n
         *    - The field will also be sent to the API in the openOrder message if the API client version is >= 56. It is sent after the stopPrice field as follows: stopPrice, trailingPct, basisPoint\n
         */
        double TrailingPercent{ get; set; }

        /**
         * @brief The Financial Advisor group the trade will be allocated to.
         * Use an empty string if not applicable.
         */
        string FaGroup{ get; set; }

        /**
         * @brief The Financial Advisor allocation profile the trade will be allocated to.
         * Use an empty string if not applicable.
         */
        string FaProfile{ get; set; }

        /**
         * @brief The Financial Advisor allocation method the trade will be allocated to.
         * Use an empty string if not applicable.
         */
        string FaMethod{ get; set; }

        /**
         * @brief The Financial Advisor percentage concerning the trade's allocation.
         * Use an empty string if not applicable.
         */
        string FaPercentage{ get; set; }


        /**
         * @brief For institutional customers only.
         * Available for institutional clients to determine if this order is to open or close a position. Valid values are O (open), C (close).
         */
        string OpenClose{ get; set; }


        /**
         * @brief The order's origin. 
         * Same as TWS "Origin" column. Identifies the type of customer from which the order originated. Valid values are 0 (customer), 1 (firm).
         */
        int Origin{ get; set; }

        /**
         * @brief -
         * For institutions only. Valid values are: 1 (broker holds shares) or 2 (shares come from elsewhere).
         */
        int ShortSaleSlot{ get; set; }

        /**
         * @brief Used only when shortSaleSlot is 2.
         * For institutions only. Indicates the location where the shares to short come from. Used only when short 
         * sale slot is set to 2 (which means that the shares to short are held elsewhere and not with IB).
         */
        string DesignatedLocation{ get; set; }

        /**
         * @brief -
         */
        int ExemptCode{ get; set; }

        /**
          * @brief The amount off the limit price allowed for discretionary orders.
          */
        double DiscretionaryAmt{ get; set; }

        /**
         * @brief Trade with electronic quotes.
         */
        bool ETradeOnly{ get; set; }

        /**
         * @brief Trade with firm quotes.
         */
        bool FirmQuoteOnly{ get; set; }

        /**
         * @brief Maximum smart order distance from the NBBO.
         */
        double NbboPriceCap{ get; set; }

        /**
         * @brief Use to opt out of default SmartRouting for orders routed directly to ASX.
         * This attribute defaults to false unless explicitly set to true. When set to false, orders routed directly to ASX will NOT use SmartRouting. When set to true, orders routed directly to ASX orders WILL use SmartRouting.
         */
        bool OptOutSmartRouting{ get; set; }

        /**
         * @brief - 
         * For BOX orders only. Values include:
         *      1 - match \n
         *      2 - improvement \n
         *      3 - transparent \n
         */
        int AuctionStrategy{ get; set; }

        /**
         * @brief The auction's starting price.
         * For BOX orders only.
         */
        double StartingPrice{ get; set; }

        /**
         * @brief The stock's reference price.
         * The reference price is used for VOL orders to compute the limit price sent to an exchange (whether or not Continuous Update is selected), and for price range monitoring.
         */
        double StockRefPrice{ get; set; }

        /**
         * @brief The stock's Delta.
         * For orders on BOX only.
         */
        double Delta{ get; set; }

        /**
          * @brief The lower value for the acceptable underlying stock price range.
          * For price improvement option orders on BOX and VOL orders with dynamic management.
          */
        double StockRangeLower{ get; set; }

        /**
         * @brief The upper value for the acceptable underlying stock price range.
         * For price improvement option orders on BOX and VOL orders with dynamic management.
         */
        double StockRangeUpper{ get; set; }


        /**
         * @brief The option price in volatility, as calculated by TWS' Option Analytics.
         * This value is expressed as a percent and is used to calculate the limit price sent to the exchange.
         */
        double Volatility{ get; set; }

        /**
         * @brief
         * Values include:\n
         *      1 - Daily Volatility
         *      2 - Annual Volatility
         */
        int VolatilityType{ get; set; }

        /**
         * @brief Specifies whether TWS will automatically update the limit price of the order as the underlying price moves.
         * VOL orders only.
         */
        int ContinuousUpdate{ get; set; }

        /**
         * @brief Specifies how you want TWS to calculate the limit price for options, and for stock range price monitoring.
         * VOL orders only. Valid values include: \n
         *      1 - Average of NBBO \n
         *      2 - NBB or the NBO depending on the action and right. \n
         */
        int ReferencePriceType{ get; set; }

        /**
         * @brief Enter an order type to instruct TWS to submit a delta neutral trade on full or partial execution of the VOL order.
         * VOL orders only. For no hedge delta order to be sent, specify NONE.
         */
        string DeltaNeutralOrderType{ get; set; }

        /**
         * @brief Use this field to enter a value if the value in the deltaNeutralOrderType field is an order type that requires an Aux price, such as a REL order. 
         * VOL orders only.
         */
        double DeltaNeutralAuxPrice{ get; set; }

        /**
         * @brief - 
         */
        int DeltaNeutralConId{ get; set; }

        /**
         * @brief -
         */
        string DeltaNeutralSettlingFirm{ get; set; }

        /**
         * @brief -
         */
        string DeltaNeutralClearingAccount{ get; set; }

        /**
         * @brief -
         */
        string DeltaNeutralClearingIntent{ get; set; }

        /**
         * @brief Specifies whether the order is an Open or a Close order and is used when the hedge involves a CFD and and the order is clearing away.
         */
        string DeltaNeutralOpenClose{ get; set; }

        /**
         * @brief Used when the hedge involves a stock and indicates whether or not it is sold short.
         */
        bool DeltaNeutralShortSale{ get; set; }

        /**
         * @brief -
         * Has a value of 1 (the clearing broker holds shares) or 2 (delivered from a third party). If you use 2, then you must specify a deltaNeutralDesignatedLocation.
         */
        int DeltaNeutralShortSaleSlot{ get; set; }

        /**
         * @brief -
         * Used only when deltaNeutralShortSaleSlot = 2.
         */
        string DeltaNeutralDesignatedLocation{ get; set; }

        /**
         * @brief -
         * For EFP orders only.
         */
        double BasisPoints{ get; set; }

        /**
         * @brief -
         * For EFP orders only.
         */
        int BasisPointsType{ get; set; }

        /**
         * @brief Defines the size of the first, or initial, order component.
         * For Scale orders only.
         */
        int ScaleInitLevelSize{ get; set; }

        /**
         * @brief Defines the order size of the subsequent scale order components.
         * For Scale orders only. Used in conjunction with scaleInitLevelSize().
         */
        int ScaleSubsLevelSize{ get; set; }

        /**
         * @brief Defines the price increment between scale components.
         * For Scale orders only. This value is compulsory.
         */
        double ScalePriceIncrement{ get; set; }

        /**
         * @brief -
         * For extended Scale orders.
         */
        double ScalePriceAdjustValue{ get; set; }

        /**
         * @brief -
         * For extended Scale orders.
         */
        int ScalePriceAdjustInterval{ get; set; }

        /**
         * @brief -
         * For extended scale orders.
         */
        double ScaleProfitOffset{ get; set; }

        /**
         * @brief -
         * For extended scale orders.
         */
        bool ScaleAutoReset{ get; set; }

        /**
         * @brief -
         * For extended scale orders.
         */
        int ScaleInitPosition{ get; set; }

        /**
          * @brief -
          * For extended scale orders.
          */
        int ScaleInitFillQty{ get; set; }

        /**
         * @brief -
         * For extended scale orders.
         */
        bool ScaleRandomPercent{ get; set; }

        /**
         * @brief For hedge orders.
         * Possible values include:\n
         *      D - delta \n
         *      B - beta \n
         *      F - FX \n
         *      P - Pair \n
         */
        string HedgeType{ get; set; }

        /**
         * @brief -
         * Beta = x for Beta hedge orders, ratio = y for Pair hedge order
         */
        string HedgeParam{ get; set; }

        /**
         * @brief The account the trade will be allocated to.
         */
        string Account{ get; set; }

        /**
         * @brief -
         * Institutions only. Indicates the firm which will settle the trade.
         */
        string SettlingFirm{ get; set; }

        /**
         * @brief Specifies the true beneficiary of the order.
         * For IBExecution customers. This value is required for FUT/FOP orders for reporting to the exchange.
         */
        string ClearingAccount{ get; set; }

        /**
        * @brief For exeuction-only clients to know where do they want their shares to be cleared at.
         * Valid values are: IB, Away, and PTA (post trade allocation).
        */
        string ClearingIntent{ get; set; }

        /**
         * @brief The algorithm strategy.
         * As of API verion 9.6, the following algorithms are supported:\n
         *      ArrivalPx - Arrival Price \n
         *      DarkIce - Dark Ice \n
         *      PctVol - Percentage of Volume \n
         *      Twap - TWAP (Time Weighted Average Price) \n
         *      Vwap - VWAP (Volume Weighted Average Price) \n
         * For more information about IB's API algorithms, refer to https://www.interactivebrokers.com/en/software/api/apiguide/tables/ibalgo_parameters.htm
        */
        string AlgoStrategy{ get; set; }

        /**
        * @brief The list of parameters for the IB algorithm.
         * For more information about IB's API algorithms, refer to https://www.interactivebrokers.com/en/software/api/apiguide/tables/ibalgo_parameters.htm
        */
        List<TagValue> AlgoParams{ get; set; }

        /**
        * @brief Allows to retrieve the commissions and margin information.
         * When placing an order with this attribute set to true, the order will not be placed as such. Instead it will used to request the commissions and margin information that would result from this order.
        */
        bool WhatIf{ get; set; }

        string AlgoId{ get; set; }

        /**
        * @brief Orders routed to IBDARK are tagged as “post only” and are held in IB's order book, where incoming SmartRouted orders from other IB customers are eligible to trade against them.
         * For IBDARK orders only.
        */
        bool NotHeld{ get; set; }

        /**
         * @brief Parameters for combo routing.
         * For more information, refer to https://www.interactivebrokers.com/en/software/api/apiguide/tables/smart_combo_routing.htm   
         */
        List<TagValue> SmartComboRoutingParams{ get; set; }

        /**
        * @brief The attributes for all legs within a combo order.
        */
        List<OrderComboLeg> OrderComboLegs{ get; set; }

        List<TagValue> OrderMiscOptions{ get; set; }

        /*
         * @brief for GTC orders.
         */
        string ActiveStartTime{ get; set; }

        /*
        * @brief for GTC orders.
        */
        string ActiveStopTime{ get; set; }

        /*
         * @brief Used for scale orders.
         */
        string ScaleTable{ get; set; }

        
    }
}
