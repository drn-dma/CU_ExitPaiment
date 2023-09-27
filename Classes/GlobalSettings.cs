using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_ExitPaiment.Classes
{
    internal class GlobalSettings
    {
        //Attributs
        private int id;
        private string name;
        private string value;
        private static List<GlobalSettings> settings;

        public GlobalSettings()
        {
            settings = new List<GlobalSettings>
            {
                this
            };
        }

        public GlobalSettings(string name, string value, int id) {
            this.id = id;
            this.name = name;
            this.value = value;
            settings = new List<GlobalSettings>
            {
                this
            };
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Value { get => value; set => this.value = value; }
        public static List<GlobalSettings> Settings { get => settings; }
        
    }
}
