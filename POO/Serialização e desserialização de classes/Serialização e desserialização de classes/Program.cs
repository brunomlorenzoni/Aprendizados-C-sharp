using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace Serialização_e_desserialização_de_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cachorro cachorro = new Cachorro("bilu", "vadio", "verde");

            Cachorro cachorroDesserializado;

            DataContractSerializer serializador = new DataContractSerializer(typeof(Cachorro));


            // serialização

            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true};
            StringBuilder contrutorString = new StringBuilder();
            XmlWriter escritorXml = XmlWriter.Create(contrutorString, xmlConfig);
            serializador.WriteObject(escritorXml, cachorro);
            escritorXml.Flush();

            string objetoSerializado = contrutorString.ToString();

            // salvando em arquivo

            string caminhoArquivo = "cachorro.xml";

            FileStream meuArquivo = File.Create(caminhoArquivo);
            meuArquivo.Close();

            File.WriteAllText(caminhoArquivo, objetoSerializado);


            // desserialização

            string conteudoObjetoSerializado = File.ReadAllText(caminhoArquivo);
            StringReader leitorStrings = new StringReader(conteudoObjetoSerializado);

            XmlReader leitorXML = XmlReader.Create(leitorStrings);

            cachorroDesserializado = (Cachorro)serializador.ReadObject(leitorXML);


            escritorXml.Close();
            leitorXML.Close();

            Console.WriteLine(cachorroDesserializado.raca);

            Console.ReadKey();


        }
    }
}
