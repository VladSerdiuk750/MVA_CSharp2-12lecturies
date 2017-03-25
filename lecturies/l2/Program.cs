using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace l2
{
    [XmlRoot(ElementName ="catalog")]
    public class Catalog 
    {
        [XmlElement(ElementName ="items")]
        public CatalogItemsCollection Items { get; set; }
    }
    public class CatalogItemsCollection
    {
        [XmlElement(ElementName ="item")]
        public List<CatalogItem> Items { get; set; }
    }
    public class CatalogItem
    {
        [XmlElement(ElementName ="MagazineID")]
        public string MagazineID
        {
            get;set;
        }
        [XmlElement(ElementName = "PublishDate")]
        public string PublishDate { get; set; }
        [XmlElement(ElementName = "ImageSmall")]
        public string ImageSmall { get; set; }
        [XmlElement(ElementName = "ImageLarge")]
        public string ImageLarge { get; set; }
        [XmlElement(ElementName = "ImageSmall2x")]
        public string ImageSmall2x { get; set; }
        [XmlElement(ElementName = "ImageLarge2x")]
        public string ImageLarge2x { get; set; }
    }
}
