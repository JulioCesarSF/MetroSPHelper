using System;
using MetroSPHelper.Enums;
using MetroSPHelper.Exceptions;
using MetroSPHelper.Models;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MetroSPHelper.Metro
{
    /// <summary>
    /// Static class to query Metro/Trem
    /// </summary>
    public static class Metro
    {
        /// <summary>
        /// Method to get a list of "Estação"
        /// </summary>
        /// <param name="timeOut">Request timeout</param>
        /// <returns>A list of "Estação"</returns>
        public static async Task<List<Estacao>> GetListEstacoesAsync(int timeOut = 2000)
        {
            var xml = await GetXmlEstacoesAsync(timeOut);
            var serializer = new XmlSerializer(typeof(Estacoes));
            using (var reader = new StringReader(xml))
            {
                var estacoes = (Estacoes)serializer.Deserialize(reader);
                return estacoes.All;
            }
        }
        /// <summary>
        /// Internal Method to get a xml with all "Estações"
        /// </summary>
        /// <param name="timeOut">Request timeout</param>
        /// <returns>Xml as string with all "Estações"</returns>
        internal static async Task<string> GetXmlEstacoesAsync(int timeOut = 2000)
        {
            var request = WebRequest.Create(Rota.GetEstacoes.GetDescription());
            request.Timeout = timeOut;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        var r = await stream.ReadToEndAsync();
                        return r;
                    }
                }
                else
                {
                    throw new ResponseException("Could not get \"Estações\"", response);
                }
            }
        }
        /// <summary>
        /// Method to get "Situação metrô" from API
        /// </summary>
        /// <param name="timeOut"></param>
        /// <returns>DiretoDoMetro</returns>
        public static async Task<DiretoDoMetro> GetSituacaoMetroAsync(int timeOut = 2000)
        {
            var xml = await GetSituacaoMetroXDocAsync(timeOut);
            var serializer = new XmlSerializer(typeof(DiretoDoMetro));
            using (var reader = new StringReader(xml.Root.Value))
            {
                var diretoDoMetro = (DiretoDoMetro)serializer.Deserialize(reader);
                return diretoDoMetro;
            }
        }
        /// <summary>
        /// Get "Situação Metrô" as XDocument
        /// </summary>
        /// <returns>xml string</returns>
        public static async Task<XDocument> GetSituacaoMetroXDocAsync(int timeOut = 2000)
        {
            var xmlString = await GetSituacaoMetroStringAsync(timeOut);
            if (xmlString is null)
            {
                return new XDocument();
            }

            return XDocument.Parse(xmlString);
        }
        /// <summary>
        /// Internal Get "Situação Metrô"
        /// </summary>
        /// <returns>xml string</returns>
        internal static async Task<string> GetSituacaoMetroStringAsync(int timeOut = 2000)
        {
            string returning = "";
            var request = (HttpWebRequest)WebRequest.Create(Rota.PostSituacaoMetro.GetDescription());
            request.Method = "POST";
            request.Headers.Add("SOAPAction", Rota.SOAPActionForPostSituacaoMetro.GetDescription());
            request.Host = Rota.HostPostSituacaoMetro.GetDescription();
            request.ContentType = "text/xml; charset=utf-8";
            request.ProtocolVersion = HttpVersion.Version11;
            request.Timeout = timeOut;
            var xmlEnvelope = XDocument.Parse(
                                @"<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                                    <soap:Body>
                                    <GetSituacaoTodasLinhas xmlns=""http://tempuri.org/"">
                                        <appId>B7758201-15AF-4246-8892-EAAFFC170515</appId>
                                    </GetSituacaoTodasLinhas>
                                    </soap:Body>
                                </soap:Envelope>");
            using (var requestStream = await request.GetRequestStreamAsync())
            {
                xmlEnvelope.Save(requestStream);
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            returning = await reader.ReadToEndAsync();
                        }
                    }
                }
            }
            return returning;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public static async Task<string> GetSituacaCPTMAsync(int timeOut = 2000)
        {
            using (var client = new WebClient())
            {
                var download = await client.DownloadStringTaskAsync(Rota.GetSituacaoCPTM.GetDescription());
                var xDoc = XDocument.Parse(download);
                return download;
            }
        }
    }
}
