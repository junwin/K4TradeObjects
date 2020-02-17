using System;
using System.Collections.Generic;
using System.Text;
//using System.ServiceModel;
using System.Runtime.Serialization;
using System.Linq;
using KaiTrade.Interfaces;

namespace K2DataObjects
{
    [DataContract]
    public class ExitTrade : IExitTrade
    {
        private string m_ExitTradeName = "";
        private string m_Side = "";
        private string m_OrdType = "";

        [DataMember]
        public string ExitTradeName
        {
            get
            {
                return m_ExitTradeName;
            }
            set
            {
                m_ExitTradeName = value;
            }
        }

        /// <summary>
        /// Side of trade
        /// </summary>
        [DataMember]
        public string Side
        {
            get
            {
                return m_Side;
            }
            set
            {
                m_Side = value;
            }
        }

        [DataMember]
        public string OrdType
        {
            get
            {
                return m_OrdType;
            }
            set
            {
                m_OrdType = value;
            }
        }
    }
}

