using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBApi.Interfaces
{
    public interface ITwsTagValueList : TWSLib.ITagValueList
    {
        List<ITwsTagValue> Tvl { get; }

        IEnumerator<ITwsTagValue> NewEnum { get; }

        ITwsTagValue this[int index] { get; }

        ITwsTagValue AddEmpty();

        ITwsTagValue Add(string tag, string value);
    }
}
