using KaiTrade.Interfaces;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace K2DataObjects
{
    [DataContract]
    public class SystemTrade : KaiTrade.Interfaces.ISystemTrade
    {
        private string m_Name;
        private string m_Side = "";
        private string m_OrdType = "";

        private List<IExitTrade> m_ExitTrades;
        //public log4net.ILog m_Log = log4net.LogManager.GetLogger("Kaitrade");

        public SystemTrade()
        {
            m_Name = "";

            m_ExitTrades = new List<IExitTrade>();
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

        [DataMember]
        public string TradeName
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        [DataMember]
        public List<IExitTrade> ExitTrades
        {
            get
            {
                return m_ExitTrades;
            }
            set
            {
                m_ExitTrades = value;
            }
        }
    }
}