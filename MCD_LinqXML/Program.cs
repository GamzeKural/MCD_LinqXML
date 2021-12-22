using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MCD_LinqXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument XDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8","yes"), 
                new XComment("Yorum satırı"), 
                new XElement("Personellerim", 
                new XElement("Personel",
                new XAttribute("ID","1"), 
                new XElement("Isim","Ahmet"),
                new XElement("Soyisim","Koç"), 
                new XElement("emailadress","ahmetkoc@gmail.com")),

                new XElement("Personel",
                new XAttribute("ID", "2"),
                new XElement("Isim", "Gamze"),
                new XElement("Soyisim", "Kural"),
                new XElement("emailadress", "gamzekural@gmail.com")))
                );
            XDoc.Save(@"C:\XML\Ornek1.xml");
        }
    }
}
