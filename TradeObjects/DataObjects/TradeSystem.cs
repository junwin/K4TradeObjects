using KaiTrade.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace K2DataObjects
{
    [DataContract]
    public class TradingSystem : ITradeSystem
    {
        private string m_ID;
        private string m_Name;
        private string m_Venue;
        private List<ISystemTrade> m_SystemTrades;
        private List<IParameter> m_Parameters;

        /// <summary>
        /// Get the type of underlying system that the trade system is based on
        /// for example a CQG tradeSystem or a CQG Condition
        /// </summary>
        private eTradeSystemBasis m_TradeSystemBasis = eTradeSystemBasis.tradeSystem;

        //public log4net.ILog m_Log = log4net.LogManager.GetLogger("Kaitrade");

        public TradingSystem()
        {
            m_Name = "";
            m_Venue = "";
            m_ID = System.Guid.NewGuid().ToString();
            m_SystemTrades = new List<ISystemTrade>();
            m_Parameters = new List<IParameter>();
        }

        [DataMember]
        public string ID
        {
            get
            {
                return m_ID;
            }
            set
            {
                m_ID = value;
            }
        }

        [DataMember]
        public eTradeSystemBasis TradeSystemBasis
        {
            get { return m_TradeSystemBasis; }
            set { m_TradeSystemBasis = value; }
        }

        [DataMember]
        public string Name
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
        public List<ISystemTrade> SystemTrades
        {
            get
            {
                return m_SystemTrades;
            }
            set
            {
                m_SystemTrades = value;
            }
        }

        [DataMember]
        public string Venue
        {
            get
            {
                return m_Venue;
            }
            set
            {
                m_Venue = value;
            }
        }

        [DataMember]
        public List<IParameter> Parameters
        {
            get { return m_Parameters; }
            set { m_Parameters = value; }
        }

        public void AddSystemTrade(ISystemTrade systemTrade)
        {
            try
            {
                m_SystemTrades.Add(systemTrade);
            }
            catch (Exception myE)
            {
                throw myE;
            }
        }
    }
}