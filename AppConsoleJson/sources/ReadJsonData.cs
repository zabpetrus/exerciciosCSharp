using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace AppConsoleJson.sources
{
    //Aqui leio o arquivo setado e envio os dados do arquivo
    //Para um objeto json para ser trabalhado

    public class ReadJsonData            
    {

        private JArray jsonaArray;


        public ReadJsonData() { }

        public ReadJsonData( string filepath )
        {
            try
            {
                using (var reader = File.OpenText(filepath))
                {
                    this.jsonaArray = JArray.Parse(reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message );  
            }
        }

        
        public JArray GetData()
        {           
            return this.jsonaArray;
        }       
    }

}
