using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AristaBitrateCalculator
{
    /// <summary>
    /// This class is responsible for reporting data about a NIC device, the data is taken from its JSON file
    /// </summary>
    public class NICReporter
    {
        String jsonPath;
        JObject jsonObj;
        
        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="jsonPath">The path to the JSON file with data about the NIC</param>
        public NICReporter(string jsonPath)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(jsonPath));
        }

        public void deserializeJSON()
        {
            var jObject = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("D:\\Documents\\Programming\\C#\\AristaBitrateCalculator\\AristaBitrateCalculator\\JSON\\arista.json"));
            Console.WriteLine("\nHere is the NIC Rx:\n" + jObject.ToString());
        }
    }
}
