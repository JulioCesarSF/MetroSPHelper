using System.ComponentModel;
using System.Xml.Serialization;

namespace MetroSPHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Linha
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("nome")]
        public string Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("situacao")]
        public string Situacao { get; set; }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Nome: {Nome}, Situação: {Situacao}";
        }
    }
}