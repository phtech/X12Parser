using System.Xml.Serialization;

namespace OopFactory.X12.Hipaa.Common
{
    public class Pricing
    {
        [XmlAttribute] public string Code { get; set; }
        [XmlAttribute] public decimal AllowedAmount { get; set; }
        [XmlAttribute] public decimal SavingsAmount { get; set; }
        [XmlAttribute] public string OrganizationIdentifier { get; set; }
    }
}