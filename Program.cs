using System;
using System.Collections.Generic;

namespace EnglishIdioms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new console application and paste the following code into your Main() method. Then write a foreach loop to produce the output in the image below.
            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
                idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
                idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
                idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
                idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
                idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
                idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
                idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
                idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
                idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
                idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

                foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                    Console.WriteLine($"{idiom.Key}: {String.Join(" ", idiom.Value)}");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Here's a new challenge");

            //Create the list which represents "objects" so only one key which is a string but contains a dictionary of string, string
            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();

            //Create the first vehicle's container dictionary
            Dictionary<string, Dictionary<string, string>> vehicleOne = new Dictionary<string, Dictionary<string, string>>();

            Console.WriteLine("");

            //Create Vehicle One's vehicle object
            Dictionary<string, string> vehicleOneVehicle = new Dictionary<string, string>();
            vehicleOneVehicle.Add("year", "2013");
            vehicleOneVehicle.Add("model", "Honda");
            vehicleOneVehicle.Add("make", "CRV");
            vehicleOneVehicle.Add("color", "silver");

            vehicleOne.Add("vehicle", vehicleOneVehicle);

            //Create Vehicle One's sales agent object
            Dictionary<string, string> vehicleOneSalesAgent = new Dictionary<string, string>();
            vehicleOneSalesAgent.Add("mobile", "615-444-1122");
            vehicleOneSalesAgent.Add("last_name", "Wilson");
            vehicleOneSalesAgent.Add("first_name", "Jessica");

            vehicleOne.Add("sales agent", vehicleOneSalesAgent);

            //Create Vehicle One's credit agency object
            Dictionary<string, string> vehicleOneCreditAgency = new Dictionary<string, string>();
            vehicleOneCreditAgency.Add("credit_provider", "JP Morgan Chase");
            vehicleOneCreditAgency.Add("account", "112345234343");

            vehicleOne.Add("credt agency", vehicleOneCreditAgency);

            //add vehicle to the list

            vehicles.Add(vehicleOne);

            foreach (Dictionary<string, Dictionary<string, string>> vehicle in vehicles) {
                foreach (KeyValuePair<string, Dictionary<string, string>> kvp in vehicle) {
                    Console.WriteLine("");
                    Console.WriteLine($"{kvp.Key}: ");
                    foreach (KeyValuePair<string, string> kvp2 in kvp.Value) {
                        Console.WriteLine($"{kvp2.Key}: {kvp2.Value}");
                    
                    }
                    
                }
            }
        }
    }
}
