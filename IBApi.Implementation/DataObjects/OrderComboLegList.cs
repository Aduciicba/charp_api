using IBApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TWSLib;

namespace IBApi.Implementation
{
    class OrderComboLegList : ITwsOrderComboLegList
    {
        public OrderComboLegList() 
            : this(new List<ITwsOrderComboLeg>())
        { }

        public OrderComboLegList(List<ITwsOrderComboLeg> ocl)
        {
            this.Ocl = ocl == null ? new List<ITwsOrderComboLeg>() : ocl;
        }

        public List<ITwsOrderComboLeg> Ocl { get; private set; }

        public ITwsOrderComboLeg this[int index]
        {
            get { return Ocl[index]; }
        }

        public IEnumerator<ITwsOrderComboLeg> NewEnum
        {
            get
            {
                return Ocl.GetEnumerator(); 
            }
        }

        public int Count
        {
            get { return Ocl.Count; }
        }

        public ITwsOrderComboLeg Add()
        {
            var rval = new OrderComboLeg();
            Ocl.Add(rval);
            return rval;
        }

        #region IOrderComboLegList implementation

        object IOrderComboLegList.this[int index]
        {
            get
            {
               return Ocl[index]; 
            }
        }

        object IOrderComboLegList._NewEnum
        {
            get
            {
                return Ocl.GetEnumerator(); 
            }
        }        

        object IOrderComboLegList.Add()
        {
            return this.Add();
        }

        #endregion
    }
}
