using System.ComponentModel;

namespace MetroSPHelper.Enums
{
    /// <summary>
    /// Routes Url
    /// </summary>
    public enum Rota
    {
        /// <summary>
        /// Get all Estações
        /// </summary>
        [Description(@"http://www.metro.sp.gov.br/app/trajeto/xt/estacoesTipoXML.asp")]
        GetEstacoes,
        /// <summary>
        /// "Metrô" status
        /// </summary>
        [Description(@"http://www.metro.sp.gov.br/Sistemas/direto-do-metro-via4/diretodoMetroHome.aspx")]
        GetMetroStatus,
        /// <summary>
        /// PostSituacaoMetro, need to use SOAPActionForPostSituacaoMetro
        /// </summary>
        [Description(@"http://apps.metrosp.com.br/api/diretodometro/v1/SituacaoLinhasMetro.asmx")]
        PostSituacaoMetro,
        /// <summary>
        /// SOAPActionForPostSituacaoMetro
        /// </summary>
        [Description(@"http://tempuri.org/GetSituacaoTodasLinhas")]
        SOAPActionForPostSituacaoMetro,
        /// <summary>
        /// apps.metrosp.com.br
        /// </summary>
        [Description(@"apps.metrosp.com.br")]
        HostPostSituacaoMetro,
        /// <summary>
        /// GetSituacaoCPTM
        /// </summary>
        [Description(@"http://www.cptm.sp.gov.br/")]
        GetSituacaoCPTM
    }
}
