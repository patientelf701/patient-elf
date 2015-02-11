using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;

namespace SandboxCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you.");

            string psaResponse = @"<TraceID>948639bd9df74f45b0566da0ff5766d8</TraceID>
<ResultCount>4</ResultCount>
<EstimatedCount>0</EstimatedCount>
<DebugString><![CDATA[
Mermaid avg latency : 0.200304 seconds.
Mermaid max latency : 0.200304 seconds on machine ch1sch080131629

]]></DebugString>
<Results>
<Result>
<DocID>18083975793659640079</DocID>
<DocType>Email</DocType>
<DocKey>) 22609fc193041c15d25deb0cedc2fa22J)</DocKey>
<m_dldwOSValue>{
    ""CreatedDateTime"": { ""id"": ""1"", ""type"": ""BT_INT64"", ""value"": ""0""},
    ""LastModifiedDateTime"": { ""id"": ""2"", ""type"": ""BT_INT64"", ""value"": ""0""},
    ""Provider"": { ""id"": ""3"", ""type"": ""BT_INT32"", ""value"": ""0""},
    ""UserId"": { ""id"": ""4"", ""type"": ""BT_STRING"", ""value"": ""72c0a3d3f0871e0cef0e223a86ab0820""},
    ""From"": { ""id"": ""6"", ""type"": ""BT_STRUCT"", ""value"": {
        ""Name"": { ""id"": ""1"", ""type"": ""BT_STRING"", ""value"": ""C C""},
        ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""patientelf701@hotmail.com""}
    }},
    ""Sender"": { ""id"": ""7"", ""type"": ""BT_STRUCT"", ""value"": {
        ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": """"}
    }},
    ""To"": { ""id"": ""8"", ""type"": ""BT_LIST"", ""value"": {
        ""size"": ""1"", ""elementType"": ""BT_STRUCT"", ""value"": 
        [{
                ""Name"": { ""id"": ""1"", ""type"": ""BT_STRING"", ""value"": ""C C""},
                ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""patientelf701@hotmail.com""}
            }
        ]
    }},
    ""ReceivedDateTime"": { ""id"": ""13"", ""type"": ""BT_INT64"", ""value"": ""635536796320000000""},
    ""Subject"": { ""id"": ""17"", ""type"": ""BT_STRING"", ""value"": ""hello this is a url""},
    ""UniqueBody"": { ""id"": ""18"", ""type"": ""BT_STRUCT"", ""value"": {
        ""ContentType"": { ""id"": ""1"", ""type"": ""BT_INT32"", ""value"": ""1""},
        ""Content"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": """"}
    }},
    ""Body"": { ""id"": ""19"", ""type"": ""BT_STRUCT"", ""value"": {
        ""ContentType"": { ""id"": ""1"", ""type"": ""BT_INT32"", ""value"": ""0""},
        ""Content"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""https:\/\/onedrive.live.com\/view.aspx?cid=5BB8A30FA0562055&resid=5BB8A30FA0562055%21109&app=Word \t\t \t   \t\t  ""}
    }}
}</m_dldwOSValue>
</Result>
<Result>
<DocID>5714738657372522619</DocID>
<DocType>Email</DocType>
<DocKey>) f521921dfd32d6fee9ba0de0d49e9e8dJ)</DocKey>
<m_dldwOSValue>{
    ""CreatedDateTime"": { ""id"": ""1"", ""type"": ""BT_INT64"", ""value"": ""0""},
    ""LastModifiedDateTime"": { ""id"": ""2"", ""type"": ""BT_INT64"", ""value"": ""0""},
    ""Provider"": { ""id"": ""3"", ""type"": ""BT_INT32"", ""value"": ""0""},
    ""UserId"": { ""id"": ""4"", ""type"": ""BT_STRING"", ""value"": ""72c0a3d3f0871e0cef0e223a86ab0820""},
    ""From"": { ""id"": ""6"", ""type"": ""BT_STRUCT"", ""value"": {
        ""Name"": { ""id"": ""1"", ""type"": ""BT_STRING"", ""value"": ""C C""},
        ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""patientelf701@hotmail.com""}
    }},
    ""Sender"": { ""id"": ""7"", ""type"": ""BT_STRUCT"", ""value"": {
        ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": """"}
    }},
    ""To"": { ""id"": ""8"", ""type"": ""BT_LIST"", ""value"": {
        ""size"": ""1"", ""elementType"": ""BT_STRUCT"", ""value"": 
        [{
                ""Name"": { ""id"": ""1"", ""type"": ""BT_STRING"", ""value"": ""C C""},
                ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""patientelf701@hotmail.com""}
            }
        ]
    }},
    ""ReceivedDateTime"": { ""id"": ""13"", ""type"": ""BT_INT64"", ""value"": ""635508348320000000""},
    ""Subject"": { ""id"": ""17"", ""type"": ""BT_STRING"", ""value"": ""hello""},
    ""UniqueBody"": { ""id"": ""18"", ""type"": ""BT_STRUCT"", ""value"": {
        ""ContentType"": { ""id"": ""1"", ""type"": ""BT_INT32"", ""value"": ""1""},
        ""Content"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": """"}
    }},
    ""Body"": { ""id"": ""19"", ""type"": ""BT_STRUCT"", ""value"": {
        ""ContentType"": { ""id"": ""1"", ""type"": ""BT_INT32"", ""value"": ""0""},
        ""Content"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""I have no idea why this isn't working.  \t\t \t   \t\t  ""}
    }}
}</m_dldwOSValue>
</Result>
<Result>
<DocID>4309665394348840692</DocID>
<DocType>Email</DocType>
<DocKey>) e5240d9de1e4fdddef60837e50b429f2J)</DocKey>
<m_dldwOSValue>{
    ""CreatedDateTime"": { ""id"": ""1"", ""type"": ""BT_INT64"", ""value"": ""0""},
    ""LastModifiedDateTime"": { ""id"": ""2"", ""type"": ""BT_INT64"", ""value"": ""0""},
    ""Provider"": { ""id"": ""3"", ""type"": ""BT_INT32"", ""value"": ""0""},
    ""UserId"": { ""id"": ""4"", ""type"": ""BT_STRING"", ""value"": ""72c0a3d3f0871e0cef0e223a86ab0820""},
    ""From"": { ""id"": ""6"", ""type"": ""BT_STRUCT"", ""value"": {
        ""Name"": { ""id"": ""1"", ""type"": ""BT_STRING"", ""value"": ""C C""},
        ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""patientelf701@hotmail.com""}
    }},
    ""Sender"": { ""id"": ""7"", ""type"": ""BT_STRUCT"", ""value"": {
        ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": """"}
    }},
    ""To"": { ""id"": ""8"", ""type"": ""BT_LIST"", ""value"": {
        ""size"": ""1"", ""elementType"": ""BT_STRUCT"", ""value"": 
        [{
                ""Name"": { ""id"": ""1"", ""type"": ""BT_STRING"", ""value"": ""C C""},
                ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""patientelf701@hotmail.com""}
            }
        ]
    }},
    ""ReceivedDateTime"": { ""id"": ""13"", ""type"": ""BT_INT64"", ""value"": ""635518699820000000""},
    ""Subject"": { ""id"": ""17"", ""type"": ""BT_STRING"", ""value"": ""hello""},
    ""UniqueBody"": { ""id"": ""18"", ""type"": ""BT_STRUCT"", ""value"": {
        ""ContentType"": { ""id"": ""1"", ""type"": ""BT_INT32"", ""value"": ""1""},
        ""Content"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": """"}
    }},
    ""Body"": { ""id"": ""19"", ""type"": ""BT_STRUCT"", ""value"": {
        ""ContentType"": { ""id"": ""1"", ""type"": ""BT_INT32"", ""value"": ""0""},
        ""Content"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""plugins are failing for me. i can't see my new meetings in the substrate. \t\t \t   \t\t  ""}
    }}
}</m_dldwOSValue>
</Result>
<Result>
<DocID>2612472870645466454</DocID>
<DocType>Email</DocType>
<DocKey>) 16a88312175c030a4216e2f8bfb3c26fJ)</DocKey>
<m_dldwOSValue>{
    ""CreatedDateTime"": { ""id"": ""1"", ""type"": ""BT_INT64"", ""value"": ""0""},
    ""LastModifiedDateTime"": { ""id"": ""2"", ""type"": ""BT_INT64"", ""value"": ""0""},
    ""Provider"": { ""id"": ""3"", ""type"": ""BT_INT32"", ""value"": ""0""},
    ""UserId"": { ""id"": ""4"", ""type"": ""BT_STRING"", ""value"": ""72c0a3d3f0871e0cef0e223a86ab0820""},
    ""From"": { ""id"": ""6"", ""type"": ""BT_STRUCT"", ""value"": {
        ""Name"": { ""id"": ""1"", ""type"": ""BT_STRING"", ""value"": ""Chris Cheng""},
        ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""chrcheng@microsoft.com""}
    }},
    ""Sender"": { ""id"": ""7"", ""type"": ""BT_STRUCT"", ""value"": {
        ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": """"}
    }},
    ""To"": { ""id"": ""8"", ""type"": ""BT_LIST"", ""value"": {
        ""size"": ""1"", ""elementType"": ""BT_STRUCT"", ""value"": 
        [{
                ""Name"": { ""id"": ""1"", ""type"": ""BT_STRING"", ""value"": ""\""patientelf701@hotmail.com\""""},
                ""Address"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""patientelf701@hotmail.com""}
            }
        ]
    }},
    ""ReceivedDateTime"": { ""id"": ""13"", ""type"": ""BT_INT64"", ""value"": ""635536901800000000""},
    ""Subject"": { ""id"": ""17"", ""type"": ""BT_STRING"", ""value"": ""hello this is a document test""},
    ""UniqueBody"": { ""id"": ""18"", ""type"": ""BT_STRUCT"", ""value"": {
        ""ContentType"": { ""id"": ""1"", ""type"": ""BT_INT32"", ""value"": ""1""},
        ""Content"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": """"}
    }},
    ""Body"": { ""id"": ""19"", ""type"": ""BT_STRUCT"", ""value"": {
        ""ContentType"": { ""id"": ""1"", ""type"": ""BT_INT32"", ""value"": ""0""},
        ""Content"": { ""id"": ""2"", ""type"": ""BT_STRING"", ""value"": ""\r\n\r\n""}
    }}
}</m_dldwOSValue>
</Result>
</Results>
";

            // Pre-process the psa response to make this valid xml.
            string appendedPSA = "<root>" + psaResponse + "</root>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(appendedPSA);

            // Get ResultCount
            XmlNode root = doc.DocumentElement;
            XmlNodeList nodeList = root.SelectNodes("ResultCount");
            int resultCount = 0;
            if (nodeList.Count == 1)
            {
                XmlNode resultCountNode = nodeList[0];
                resultCount = Convert.ToInt32(resultCountNode.InnerText);
            }

            // Create the output schema object.

            if (resultCount > 0)
            {
                // Read in the results
                XmlNodeList resultNodeList = root.SelectNodes("Result");

                // For each result node, first get the result type, and then deserialize the value.
                foreach (XmlNode resultNode in resultNodeList)
                {
                    XmlNodeList resultTypeNodes = resultNode.SelectNodes("DocType");
                    XmlNodeList valueNodes = resultNode.SelectNodes("m_dldwOSValue");
                    if (resultTypeNodes.Count == 1 && valueNodes.Count == 1)
                    {
                        XmlNode resultTypeNode = resultTypeNodes[0];
                        XmlNode valueNode = valueNodes[0];
                        string docType = resultTypeNode.InnerText;
                        string resultValue = valueNode.InnerText;
                    }
                }
            }


            // Practice string operations and substrings.
            string s = "precure";
            Console.WriteLine(s);
            Console.WriteLine(s.IndexOf("e")); // 2
            Console.WriteLine(s.IndexOf("ee")); // -1
            Console.WriteLine(s.Substring(1, 4)); // recu
            Console.WriteLine(s.Substring(2, 4)); // ecur

            // This is in System.Collections.
            // Practice using Arraylist and foreach loop.
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Cordelia");
            arrayList.Add("Sumia");
            foreach(string name in arrayList)
            {
                Console.WriteLine(name);
            }

            //
            Console.WriteLine("Moving onto Cars...");
            Car c = new Car();
            //ICollection<Car> cars = new List<Car>();
            //for (int i = 0; i < 5; i++)
           /// {
            //    cars.Add(new Car());
            //}
            // cars.Count;

            // In order to pass by reference, we have to add the ref keyword.
            // Using the ref keyword here corresponds to a ref keyword in the method signature.
            int myID = 5;
            c.AddFiveRef(ref myID);
            Console.WriteLine(myID);

            // passing a string to a method
            // only the ref one passes by reference
            // the method signatures don't match each other
            string myWord = "Word";
            c.AddString(myWord);
            c.AddStringRef(ref myWord);
            Console.WriteLine(myWord);

            // If a method has a ref modifier, it has to be initialized before passing it as a parameter
            // If a method has an out modifier, it must be initialized within the method at least.
            // You can send an initialized variable in, but it will get lost.
            LicensePlate lp = new LicensePlate();
            lp.number = 4;
            lp.word = "hahaha";
            c.CreateLicensePlate(out lp);
            Console.WriteLine("LPnumber " + lp.number.ToString());
            Console.WriteLine("LPword " + lp.word);

            // Object initializer:
            Car cccc = new Car { TrunkOpen = false };

            // can actually make extension methods
            // of like string and such. use this in parameter name
            // public static bool IsNumeric(this string s)

            // Polymorphism
            // you can have B inherit from A
            // and C inherit from B with 
            // virtual method in A and override method in B and C
            // you can stop the override by using sealed.
            // public sealed override void myMethod()
            // you can then redefine the method by using
            // public new void myMethod()

            // Practice reading and writing to the console.
            //int number;
            //Console.WriteLine("Please enter a number:");
            //number = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
}
