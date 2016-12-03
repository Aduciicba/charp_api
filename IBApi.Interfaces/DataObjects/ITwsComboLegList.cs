using IBApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TWSLib;

namespace IBApi.Interfaces
{
    public interface ITwsComboLegList : IComboLegList
    {
        List<ITwsComboLeg> Ocl { get; }       

        IEnumerator<ITwsComboLeg> NewEnum { get; }

        ITwsComboLeg this[int index] { get; }

        ITwsComboLeg Add();
    }
}
