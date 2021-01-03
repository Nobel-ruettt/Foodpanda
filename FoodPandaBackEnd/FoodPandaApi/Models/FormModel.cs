using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPandaApi.Models
{
    public class FormModel
    {
        public string SourceType { get; set; }
        public List<FieldDefinitionModel> FieldDefinitions { get; set; }
    }
}
