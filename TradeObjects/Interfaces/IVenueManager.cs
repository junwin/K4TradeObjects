using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaiTrade.Interfaces
{
    public interface IVenueManager
    {
        /// <summary>
        /// Add a venue based on its XML databinding
        /// </summary>
        /// <param name="myCode"></param>
        /// <param name="myVenue"></param>
        //void AddVenue(string myCode, KAI.kaitns.Venue myVenue);

        /// <summary>
        /// Get a venue object given its venue code
        /// </summary>
        /// <param name="myCode"></param>
        /// <returns></returns>
        KaiTrade.Interfaces.IVenue GetVenue(string myCode);

        /// <summary>
        /// Get a list of all the venues
        /// </summary>
        /// <returns></returns>
        List<string> GetVenueList();

        /// <summary>
        /// Get a list of all the venue definition databindings
        /// </summary>
        /// <returns></returns>
        //List<KAI.kaitns.Venue> GetVenueDefinition();
    }
}
