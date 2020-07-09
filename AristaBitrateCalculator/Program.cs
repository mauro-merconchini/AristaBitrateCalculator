using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace AristaBitrateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //These statements will use JSON.Net to extrapolate data from the file

            string jsonPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"JSON\arista.json");
            var parsedNicData = JsonConvert.DeserializeObject<NicObj>(File.ReadAllText(jsonPath));

            //This is the Hz measurement
            int frequency = 2;

            //Call the functions to calculate the bitrate for the first (and only) NIC and print the result
            Console.WriteLine(String.Format("Rx Bitrate: {0} Gbps", parsedNicData.NIC[0].RxBitrate(frequency)));
            Console.WriteLine(String.Format("Tx Bitrate: {0} Gbps", parsedNicData.NIC[0].TxBitrate(frequency)));
        }
    }
}
