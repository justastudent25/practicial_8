using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestPechat
{
    internal class statistika
    {
        public static void Statistica(user statistic)
        {
            XmlSerializer xml = new XmlSerializer(typeof(user));
            using (FileStream fs = new FileStream("C:\\Users\\кальмар в эболе\\Desktop\\testin.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, statistic);
            }
            Console.WriteLine("Успешно сохранилось");
        }
    }
}
