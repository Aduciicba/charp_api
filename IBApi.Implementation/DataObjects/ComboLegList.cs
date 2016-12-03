using IBApi.Implementation;
using IBApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TWSLib;

namespace IBApi.Implementation
{
    class ComboLegList : ITwsComboLegList
    {
        public ComboLegList() 
            : this(new List<ITwsComboLeg>())
        {            
        }

        public ComboLegList(List<ITwsComboLeg> cbl)
        {
            this.Ocl = cbl == null ? new List<ITwsComboLeg>() : cbl;
        }

        public List<ITwsComboLeg> Ocl { get; private set; }

        public IEnumerator<ITwsComboLeg> NewEnum
        {
            get { return Ocl.GetEnumerator(); }
        }       

        public int Count
        {
            get { return Ocl.Count; }
        }

        public ITwsComboLeg this[int index]
        {
            get
            {
                return Ocl[index];
            }
        }

        public ITwsComboLeg Add()
        {
            var rval = new ComboLeg();
            Ocl.Add(rval);
            return rval;
        }

        #region IComboLegList implementation
        object IComboLegList._NewEnum
        {
            get { return Ocl.GetEnumerator(); }
        }

        object IComboLegList.this[int index]
        {
            get { return Ocl[index]; }
        }

        object IComboLegList.Add()
        {
            return (ITwsComboLeg)this.Add();
        }

        #endregion
    }
}
