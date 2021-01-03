using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPandaApi.Models
{
    public class FieldDefinitionModel
    {
        public string Header { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public bool IsRequired { get; set; }
    }
}
