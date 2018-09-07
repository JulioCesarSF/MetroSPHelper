using System.Collections.Generic;
using System.Xml.Serialization;

namespace MetroSPHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Linhas
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("linha")]
        public List<Linha> Linha { get; set; }
    }
}