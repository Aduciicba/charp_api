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
     * @class ComboLeg
     * @brief Class representing a leg within combo orders.
     * @sa Order
     */
    [ComVisible(true)]
    public interface ITwsComboLeg
    {
        
        /**
         * @brief The Contract's IB's unique id
         */
        int ConId { get; set; }

        /**
          * @brief Select the relative number of contracts for the leg you are constructing. To help determine the ratio for a specific combination order, refer to the Interactive Analytics section of the User's Guide.
          */
        int Ratio { get; set; }

        /**
         * @brief The side (buy or sell) of the leg:\n
         *      - For individual accounts, only BUY and SELL are available. SSHORT is for institutions.
         */
        string Action { get; set; }
        /**
         * @brief The destination exchange to which the order will be routed.
         */
        string Exchange { get; set; }

        /**
        * @brief Specifies whether an order is an open or closing order.
        * For instituational customers to determine if this order is to open or close a position.
        *      0 - Same as the parent security. This is the only option for retail customers.\n
        *      1 - Open. This value is only valid for institutional customers.\n
        *      2 - Close. This value is only valid for institutional customers.\n
        *      3 - Unknown
        */
        int OpenClose { get; set; }

        /**
         * @brief For stock legs when doing short selling.
         * Set to 1 = clearing broker, 2 = third party
         */
        int ShortSaleSlot { get; set; }

        /**
         * @brief When ShortSaleSlot is 2, this field shall contain the designated location.
         */
        string DesignatedLocation { get; set; }

        /**
         * @brief -
         */
        int ExemptCode { get; set; }


    }
}
