using LAB01v2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01v2.Services
{
    internal class FileIOService
    {
        private readonly string PATH;

        public FileIOService(string path) { PATH = path; }
        public BindingList<TableModel> Load()
        {
            var fileExists = File.Exists(PATH);
            if(!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<TableModel>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<TableModel>>(fileText);
            }
        }

        public void Save(BindingList<TableModel> dataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(dataList);
                writer.Write(output);
            }
        }

    }
}
