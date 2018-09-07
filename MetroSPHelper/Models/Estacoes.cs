using System.Collections.Generic;
using System.Xml.Serialization;

namespace MetroSPHelper.Models
{
    /// <summary>
    /// Representation of "Estações"
    /// </summary>
    [XmlRoot("estacoes")]
    public class Estacoes
    {
        /// <summary>
        /// List of "Estação"
        /// </summary>
        [XmlElement("estacao")]
        public List<Estacao> All { get; set; }
    }
}
