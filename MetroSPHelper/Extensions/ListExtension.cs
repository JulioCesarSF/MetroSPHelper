using MetroSPHelper.Enums;
using MetroSPHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MetroSPHelper.Extensions
{
    /// <summary>
    /// List of Estacao extension
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// Method to Get "Estação" by "Tipo"
        /// </summary>
        /// <param name="estacoes">List of "Estação"</param>
        /// <param name="estacaoTipo">Type of "Estação" - EstacaoTipo</param>
        /// <returns>A List of "Estação" where "Tipo" equals "EstacaoTipo"</returns>
        public static List<Estacao> GetByTipo(this List<Estacao> estacoes, EstacaoTipo estacaoTipo)
        {
            if(estacoes is null || estacoes.Count == 0)
                throw new ArgumentException("\"Estações\" is empty");

            var byType = estacoes.Where(_ => _.Tipo.ToLower().Equals(estacaoTipo.GetDescription().ToLower())).ToList();
            return byType;
        }
        /// <summary>
        /// Method to Get "Estação" by "EstacaoTipo"
        /// </summary>
        /// <param name="estacoes">List of "Estação"</param>
        /// <param name="estacaoTipo">Type of "Estação"</param>
        /// <returns>A List of "Estação" where "TipoId" equals "EstacaoTipo"</returns>
        public static List<Estacao> GetByTipoId(this List<Estacao> estacoes, EstacaoTipo estacaoTipo)
        {
            if (estacoes is null || estacoes.Count == 0)
                throw new ArgumentException("\"Estações\" is empty");

            var byType = estacoes.Where(_ => _.TipoId == (int)estacaoTipo).ToList();
            return byType;
        }
        /// <summary>
        /// Method to Get "Estação" by "Linha" ("Color")
        /// </summary>
        /// <param name="estacoes">List of "Estação"</param>
        /// <param name="linhaColor">Type of "Linha"</param>
        /// <returns>A List of "Estação" where "Linha" equals "LinhaColor"</returns>
        public static List<Estacao> GetByColor(this List<Estacao> estacoes, LinhaColor linhaColor)
        {
            if (estacoes is null || estacoes.Count == 0)
                throw new ArgumentException("\"Estações\" is empty");

            var byType = estacoes.Where(_ => _.Linha.ToLower().Equals(linhaColor.GetDescription().ToLower())).ToList();
            return byType;
        }
    }
}
