using IBApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IBApi.Interfaces
{
    public interface ITwsApi : TWSLib.ITws
    { 
        #region methods
        void reqMktData(int id, string symbol, string secType, string expiry, double strike,
                  string right, string multiplier, string exchange, string primaryExchange,
                  string currency, string genericTicks, bool snapshot, ITwsTagValueList options);

        void reqMktData2(int id, string localSymbol, string secType, string exchange,
                  string primaryExchange, string currency, string genericTicks,
                  bool snapshot, ITwsTagValueList options);

        void reqMktDepth(int id, string symbol, string secType, string expiry, double strike,
                  string right, string multiplier, string exchange, string curency, int numRows, ITwsTagValueList options);

        void reqMktDepth2(int id, string localSymbol, string secType, string exchange, string curency, int numRows, ITwsTagValueList options);

        void reqHistoricalData(int id, string symbol, string secType, string expiry, double strike,
                  string right, string multiplier, string exchange, string curency, int isExpired,
                  string endDateTime, string durationStr, string barSizeSetting, string whatToShow,
                  int useRTH, int formatDate, ITwsTagValueList options);

        void reqScannerSubscription(int tickerId, int numberOfRows, string instrument,
           string locationCode, string scanCode, double abovePrice, double belowPrice,
           int aboveVolume, double marketCapAbove, double marketCapBelow, string moodyRatingAbove,
           string moodyRatingBelow, string spRatingAbove, string spRatingBelow,
           string maturityDateAbove, string maturityDateBelow, double couponRateAbove,
           double couponRateBelow, int excludeConvertible, int averageOptionVolumeAbove,
           string scannerSettingPairs, string stockTypeFilter, ITwsTagValueList options);

        void reqRealTimeBars(int tickerId, string symbol, string secType, string expiry, double strike,
           string right, string multiplier, string exchange, string primaryExchange, string currency,
           int isExpired, int barSize, string whatToShow, int useRTH, ITwsTagValueList options);

        void reqFundamentalData(int reqId, ITwsContract contract, string reportType);

        void calculateImpliedVolatility(int reqId, ITwsContract contract, double optionPrice, double underPrice);
        [DispId(95)]
        void calculateOptionPrice(int reqId, ITwsContract contract, double volatility, double underPrice);

        void reqContractDetailsEx(int reqId, ITwsContract contract);

        void reqMktDataEx(int tickerId, ITwsContract contract, string genericTicks, bool snapshot, ITwsTagValueList options);

        void reqMktDepthEx(int tickerId, ITwsContract contract, int numRows, ITwsTagValueList options);

        void placeOrderEx(int orderId, ITwsContract contract, ITwsOrder order);

        void reqExecutionsEx(int reqId, ITwsExecutionFilter filter);

        void exerciseOptionsEx(int tickerId, ITwsContract contract, int exerciseAction,
           int exerciseQuantity, string account, int @override);

        void reqHistoricalDataEx(int tickerId, ITwsContract contract, string endDateTime,
           string duration, string barSize, string whatToShow, bool useRTH, int formatDate, ITwsTagValueList options);

        void reqRealTimeBarsEx(int tickerId, ITwsContract contract, int barSize, string whatToShow, bool useRTH, ITwsTagValueList options);

        void reqScannerSubscriptionEx(int tickerId, ITwsScannerSubscription subscription, ITwsTagValueList options);

        ITwsContract createContract();

        ITwsComboLegList createComboLegList();

        ITwsOrder createOrder();

        ITwsExecutionFilter createExecutionFilter();

        ITwsScannerSubscription createScannerSubscription();

        ITwsUnderComp createUnderComp();

        ITwsTagValueList createTagValueList();

        ITwsOrderComboLegList createOrderComboLegList();
        #endregion
    }
}
