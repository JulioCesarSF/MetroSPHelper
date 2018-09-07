using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MetroSPHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot("diretodometro")]
    public class DiretoDoMetro
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("linhas")]
        public Linhas Linhas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("atualizacao")]
        public string Atualizacao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("atualizacaoViaQuatro")]
        public string AtualizacaoViaQuatro { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("geracao")]
        public string Geracao { get; set; }
    }
}
