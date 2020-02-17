using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaiTrade.Interfaces
{
    public enum eTradeSystemBasis { simpleCondition, tradeSystem };
    /// <summary>
    /// This interface describes a generic trade system, that will be associated with some
    /// external system/broker
    /// </summary>
    public interface ITradeSystem
    {
        /// <summary>
        /// Unique ID for the system
        /// </summary>
        string ID
        { get; set; }

        /// <summary>
        /// Get the type of underlying system that the trade system is based on
        /// for example a CQG tradeSystem or a CQG Condition
        /// </summary>
        eTradeSystemBasis TradeSystemBasis
        { get; set; }

        /// <summary>
        /// Freindly name of the system
        /// </summary>
        string Name
        { get; set; }

        /// <summary>
        /// Name of the venue that trading system runs on
        /// </summary>
        string Venue
        { get; set; }

        /// <summary>
        /// Add a system trade
        /// </summary>
        /// <param name="systemTrade"></param>
        void AddSystemTrade(ISystemTrade systemTrade);

        /// <summary>
        /// List of system trades that can be made by the trading system
        /// </summary>
        List<ISystemTrade> SystemTrades
        { get; set; }

        /// <summary>
        /// Paramters associated with the trade system
        /// </summary>
        List<IParameter> Parameters
        { get; set; }
    }

    /// <summary>
    /// This defines a system trade- note that
    /// that a trading systems supports 1..N system trades e.g. GoLong,  GoShort
    /// each of these trades can have one or more exits
    /// </summary>
    public interface ISystemTrade
    {
        /// <summary>
        /// Name of system trade - this name will be used as an entry trigger
        /// </summary>
        string TradeName
        { get; set; }

        /// <summary>
        /// Side of trade
        /// </summary>
        string Side
        { get; set; }

        /// <summary>
        /// Order Type
        /// </summary>
        string OrdType
        { get; set; }

        /// <summary>
        /// The list of exit trades that can be used by this system trade
        /// </summary>
        List<IExitTrade> ExitTrades
        { get; set; }
    }

    /// <summary>
    /// This defines an exit trade made by some trading system
    /// </summary>
    public interface IExitTrade
    {
        /// <summary>
        /// Name of system trade  - will be in the Name on a trade signal and used as an exit trigger
        /// </summary>
        string ExitTradeName
        { get; set; }

        /// <summary>
        /// Side of trade
        /// </summary>
        string Side
        { get; set; }

        /// <summary>
        /// Order Type
        /// </summary>
        string OrdType
        { get; set; }
    }
}

