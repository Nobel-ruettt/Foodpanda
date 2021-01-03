using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FoodPandaApi.Models;
using Newtonsoft.Json;

namespace FoodPandaApi.FormJsons
{
    public static class FormGetterService
    {
        public static FormModel GetFormModelByFormName(string formName)
        {
            DirectoryInfo d = new DirectoryInfo(@"D:\Codes\FoodPanda\FoodPandaBackEnd\FoodPandaApi\FormJsons");//Assuming Test is your Folder
            var files = d.GetFiles("*.json").ToList(); //Getting Text files
            var neededFile = files
                .FirstOrDefault(file => string.Equals(formName+".json",file.Name, StringComparison.InvariantCultureIgnoreCase));

            if (neededFile == null)
            {
                return null;
            }

            var jsonString = File.ReadAllText(neededFile.FullName);
            var formModel = JsonConvert.DeserializeObject<FormModel>(jsonString);

            return formModel;
        }
    }
}
