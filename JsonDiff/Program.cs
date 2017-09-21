using JsonDiff.SimpleHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalObj = File.ReadAllText("source.json");
            var updatedObj = File.ReadAllText("target.json");

            var diff = ObjectDiffPatch.GenerateDiff(JsonConvert.DeserializeObject(originalObj.ToString()), JsonConvert.DeserializeObject(updatedObj.ToString()));

            // original properties values
            Console.WriteLine(diff.OldValues.ToString());

            // updated properties values
            Console.WriteLine(diff.NewValues.ToString());

        }
    }
}
