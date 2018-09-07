using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MetroSPHelper.Enums
{
    /// <summary>
    /// Represent "Tipo" of "Estação"
    /// </summary>
    public enum EstacaoTipo
    {
        /// <summary>
        /// "Metrô"
        /// </summary>
        [Description("Metrô")]
        METRO = 1,
        /// <summary>
        /// EMTU
        /// </summary>
        [Description("EMTU")]
        EMTU = 3,
        /// <summary>
        /// CPTM
        /// </summary>
        [Description("CPTM")]
        CPTM = 2
    }
}
