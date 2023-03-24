using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;

namespace OitavoProjeto
{
    internal static class Serializador
    {
        static private DataContractSerializer serializador = new DataContractSerializer(typeof(BaseDeDados));


        public static void Serializa(string pCaminhoArquivoXml, BaseDeDados pBaseDeDados)
        {
            XmlWriterSettings Xmlconfig = new XmlWriterSettings { Indent = true };
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter escritorDeXml = XmlWriter.Create(construtorDeString, Xmlconfig);
            serializador.WriteObject(escritorDeXml, pBaseDeDados);
            escritorDeXml.Flush();
            string objetoSerializador = construtorDeString.ToString();

            FileStream meuArquivoXml = File.Create(pCaminhoArquivoXml);
            meuArquivoXml.Close();
            File.WriteAllText(pCaminhoArquivoXml, objetoSerializador);
            escritorDeXml.Close();

        }

        public static BaseDeDados Desserializa(string pCaminhoArquivoXml)
        {
            try
            {
                if (File.Exists(pCaminhoArquivoXml))
                {
                    string conteudoDoObjetoSerializado = File.ReadAllText(pCaminhoArquivoXml);

                    StringReader leitorString = new StringReader(conteudoDoObjetoSerializado);
                    XmlReader leitorDeXml = XmlReader.Create(leitorString);
                    BaseDeDados baseDeDadosTemp = (BaseDeDados)serializador.ReadObject(leitorDeXml);
                    return baseDeDadosTemp;
                }
                else { return null; }
            }
            catch (Exception e)
            {
                return null;  
            }


        }


    }
}
