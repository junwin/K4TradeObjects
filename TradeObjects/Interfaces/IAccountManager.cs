using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaiTrade.Interfaces
{
    /// <summary>
    /// Manage a set of accounts and provide access by trade venue
    /// </summary>
    public interface IAccountManager
    {
        /// <summary>
        /// create and register an account
        /// </summary>
        /// <returns>an account</returns>
        IAccount CreateAccount();

        /// <summary>
        /// Get a list of all account IDs
        /// </summary>
        /// <returns></returns>
        List<string> GetAccountID();

        /// <summary>
        /// Get a list of account ID's for a specific venue
        /// </summary>
        /// <param name="myVenueCode"></param>
        /// <param name="uid">system assigned user ID</param>
        /// <returns></returns>
        List<string> GetAccountID(string uid, string myVenueCode);

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="myID"></param>
        /// <returns></returns>
        IAccount GetAccount(string myID);

        /// <summary>
        /// Add an account based on a data binding version of the account
        /// </summary>
        /// <param name="myXmlAccount">string of XML</param>
        void AddAccount(string myXmlAccount);

    }
}
