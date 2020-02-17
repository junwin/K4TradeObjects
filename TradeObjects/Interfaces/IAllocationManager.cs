using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaiTrade.Interfaces
{
    public interface IAllocationManager
    {
        /// <summary>
        /// Create an empty allocation and add it to the manager
        /// </summary>
        /// <param name="myName"> name of desired allocation</param>
        /// <returns></returns>
        KaiTrade.Interfaces.IAllocation CreateAllocation(string myname);

        /// <summary>
        /// Get an allocation by name
        /// </summary>
        /// <param name="myName"> name of desired allocation</param>
        /// <returns></returns>
        KaiTrade.Interfaces.IAllocation GetAllocation(string myName);

        /// <summary>
        /// Get an allocation by ID
        /// </summary>
        /// <param name="myID"> ID of desired allocation</param>
        /// <returns></returns>
        KaiTrade.Interfaces.IAllocation GetAllocationID(string myID);

        /// <summary>
        /// Get a clone of a named allocation - caution this will be
        /// identical in all respects except for the identity
        /// </summary>
        /// <param name="myName"> name of desired allocation</param>
        /// <returns></returns>
        KaiTrade.Interfaces.IAllocation CloneAllocation(string myName);

        /// <summary>
        /// Get a clone of the allocation with the ID specified - this will be
        /// identical in all respects except for the identity
        /// </summary>
        /// <param name="myName"> name of desired allocation</param>
        /// <returns></returns>
        KaiTrade.Interfaces.IAllocation CloneAllocationID(string myID);

        /// <summary>
        /// get a list of allocation ID's
        /// </summary>
        /// <returns></returns>
        List<string> GetAllocationNames();

        /// <summary>
        /// set up from an XML databinding
        /// </summary>
        /// <param name="myAllocation"></param>
        void From(string myAllocationSet);

        /// <summary>
        /// Return an XMLDB representation
        /// </summary>
        /// <returns></returns>
        string ToXMLDB();
    }
}
