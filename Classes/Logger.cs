using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;

namespace CU_ExitPaiment.Classes
{
    internal class Logger
    {
        //Attributs
        private static string _mainPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CU_App";
        public static string MainPath { get { return _mainPath; } }
        public static void WriteLog(Exception e, string message)
        {
            
            string textFilePath = _mainPath + "\\logs.txt";

            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CU_App"))
            {
                using (StreamWriter sw = new StreamWriter(textFilePath, true))
                {
                    sw.WriteLine($"{DateTime.Now} : \n\n {message} \n\n Message ---->> {e.Message} \n\n\n");
                }
            }
            else
            {
                Directory.CreateDirectory(_mainPath);

                using (StreamWriter sw = new StreamWriter(textFilePath, true))
                {
                    sw.WriteLine($"{DateTime.Now} : \n\n {message} \n\n Message ---->> {e.Message} \n\n\n");
                }

            }


        }


        public static void InitParam()
        {
            string jsonFilePath = _mainPath + "\\settings.json";

            //Ajout des parametres par défaut à l'application
            var jsonAdd = new { Parameters = new[] {
                 new GlobalSettings()
                 {
                    Id = 0,
                    Name = "Server_Adress",
                    Value = "DO_LAPTOP\\SQLEXPRESS"
                 }
            }};
            

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(jsonAdd, options);

            
            Directory.CreateDirectory(_mainPath );
            using (StreamWriter sw = new StreamWriter(jsonFilePath, false))
            {
                sw.WriteLine(json);
            }
            
        }

        public static void ReadParam()
        {
            string json = File.ReadAllText(_mainPath + "\\settings.json");
            JsonObject jsonObj = (JsonObject)JsonNode.Parse(json);
            JsonArray jsonArray = (JsonArray)jsonObj["Parameters"];

            foreach (JsonObject item in jsonArray)
            {
                new GlobalSettings()
                {
                    Id = (int)item["Id"],
                    Name = (string)item["Name"],
                    Value = (string)item["Value"]
                };
            }

        }

        public static bool UpdateParam(string paramName, dynamic newValue) {
            string json = File.ReadAllText(_mainPath + "\\settings.json");
            string jsonFilePath = _mainPath + "\\settings.json";

            JsonObject jsonObj = (JsonObject)JsonNode.Parse(json);
            JsonArray jsonArray = (JsonArray)jsonObj["Parameters"];

            foreach(JsonObject item in jsonArray)
            {
                if ((string)item["Name"] == paramName)
                {
                    item["Value"] = (string)newValue;

                    
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonTemp = JsonSerializer.Serialize(new { Parameters = jsonArray}, options);


                    using (StreamWriter sw = new StreamWriter(jsonFilePath, false))
                    {
                        sw.WriteLine(jsonTemp);
                    }

                    return true;
                }
            }
            return false;
        }

    }
}
