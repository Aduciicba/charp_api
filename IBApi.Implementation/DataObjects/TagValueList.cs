using IBApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TWSLib;
using System.Collections;

namespace IBApi.Implementation
{
    class TagValueList : ITwsTagValueList
    {
        public static implicit operator KeyValuePair<string, string>[] (TagValueList list)
        {
            return list == null ? null : list.Tvl.Select(x => new KeyValuePair<string, string>(x.Tag, x.Value)).ToArray();
        }

        public List<ITwsTagValue> Tvl { get; private set; }

        public TagValueList() 
            : this(new List<ITwsTagValue>())
        { }
        public TagValueList(List<ITwsTagValue> tvl)
        {
            this.Tvl = tvl == null ? new List<ITwsTagValue>() : tvl;
        }

        public IEnumerator<ITwsTagValue> NewEnum
        {
            get { return Tvl.GetEnumerator(); }
        }

        public ITwsTagValue this[int index]
        {
            get { return Tvl[index]; }
        }

        public int Count
        {
            get { return Tvl.Count; }
        }


        public ITwsTagValue AddEmpty()
        {
            var rval = new TagValue();

            Tvl.Add(rval);

            return rval;
        }

        public ITwsTagValue Add(string tag, string value)
        {
            var rval = new TagValue(tag, value);

            Tvl.Add(rval);

            return rval;
        }

        #region ITagValueList implementation

        object ITagValueList._NewEnum
        {
            get { return Tvl.GetEnumerator(); }
        }

        object ITagValueList.this[int index]
        {
            get { return Tvl[index]; }
        }

        object ITagValueList.AddEmpty()
        {
            return this.AddEmpty();
        }

        object ITagValueList.Add(string tag, string value)
        {
            return this.Add(tag, value);
        }

        #endregion
    }
}
