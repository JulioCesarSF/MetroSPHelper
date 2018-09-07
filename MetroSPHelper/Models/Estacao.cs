using System.Xml.Serialization;

namespace MetroSPHelper.Models
{
    /// <summary>
    /// Representation of an Estação
    /// </summary>
    public class Estacao
    {
        /// <summary>
        /// Id attribute
        /// </summary>
        [XmlAttribute("estacaoId")]
        public int Id { get; set; }
        /// <summary>
        /// Nome attribute
        /// </summary>
        [XmlAttribute("nome")]
        public string Nome { get; set; }
        /// <summary>
        /// Ordem attribute ("nome")
        /// </summary>
        [XmlAttribute("ordem")]
        public int Ordem { get; set; }
        /// <summary>
        /// LinhaId attribute
        /// </summary>
        [XmlAttribute("linhaId")]
        public int LinhaId { get; set; }
        /// <summary>
        /// Linha attribute ("nome")
        /// </summary>
        [XmlAttribute("linha")]
        public string Linha { get; set; }
        /// <summary>
        /// TipoId attribute
        /// </summary>
        [XmlAttribute("tipoId")]
        public int TipoId { get; set; }
        /// <summary>
        /// Tipo attribute ("nome")
        /// </summary>
        [XmlAttribute("tipo")]
        public string Tipo { get; set; }

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>$"Id: {Id}, Nome: {Nome}, Ordem: {Ordem}, LinhaId: {LinhaId}, Linha: {Linha}, TipoId: {TipoId}, Tipo:{Tipo}"</returns>
        public override string ToString()
        {
            return
                $"Id: {Id}, Nome: {Nome}, Ordem: {Ordem}, LinhaId: {LinhaId}, Linha: {Linha}, TipoId: {TipoId}, Tipo:{Tipo}";
        }
    }
}
