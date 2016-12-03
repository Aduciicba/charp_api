using IBApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBApi.Interfaces
{
    public interface ITwsOrderComboLegList : TWSLib.IOrderComboLegList
    {
        List<ITwsOrderComboLeg> Ocl { get; }

        IEnumerator<ITwsOrderComboLeg> NewEnum { get; }

        ITwsOrderComboLeg this[int index] { get; }

        ITwsOrderComboLeg Add();
    }
}
