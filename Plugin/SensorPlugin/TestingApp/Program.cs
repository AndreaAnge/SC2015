using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorPlugin;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(d2LogicalModel));

            //XElement el = XElement.Load("../../Data/MIDAS_Loop_Traffic_Data.xml");
            TextReader reader = new StreamReader("../../Data/MIDAS_Loop_Traffic_Data.xml");
            d2LogicalModel model = (d2LogicalModel)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
