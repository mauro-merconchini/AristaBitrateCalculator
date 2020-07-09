using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AristaBitrateCalculator
{
    /// <summary>
    /// This class inherits from DeviceObj and creates an array of NICs with their appropriate attributes
    /// </summary>
    class NicObj : DeviceObj
    {
        public Nic[] NIC { get; set; }

        /// <summary>
        /// This is the class that gets the attributes of a NIC from the parsed JSON file
        /// </summary>
        public class Nic
        {
            public string Description { get; set; }
            public string MAC { get; set; }
            public string Timestamp { get; set; }
            public string Rx { get; set; }
            public string Tx { get; set; }
            
            /// <summary>
            /// This method converts the Rx value from a string to a more useful data type
            /// </summary>
            /// <returns>The number of octs from Rx as a long</returns>
            public long RxOcts()
            {
                return Int64.Parse(Rx);
            }

            /// <summary>
            /// This method converts the Tx value from a string to a more useful data type
            /// </summary>
            /// <returns>The number of octs from Tx as a long</returns>
            public long TxOcts()
            {
                return Int64.Parse(Tx);
            }

            /// <summary>
            /// This method computes the bitrate for Rx based on a specified frequency
            /// </summary>
            /// <returns>The bitrate of Rx in Gbps</returns>
            public double RxBitrate(int frequency)
            {
                return (RxOcts() * 8) * frequency / 1000000000;
            }

            /// <summary>
            /// This method computes the bitrate for Tx based on a specified frequency
            /// </summary>
            /// <returns>The bitrate of Tx in Gbps</returns>
            public double TxBitrate(int frequency)
            {
                return (TxOcts() * 8) * frequency / 1000000000;
            }
        }
    }
}
