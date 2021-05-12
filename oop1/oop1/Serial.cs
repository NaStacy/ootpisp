using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace oop1
{
    public class Serial
    {
        readonly JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };

        private SaveFileDialog saveFile = new SaveFileDialog();
        public void Serialization(Undo undo)
        {
            JsonSerializer jsonSerializer = JsonSerializer.Create(settings);
            try
            {
                saveFile.DefaultExt = ".json";
                saveFile.Filter = "JSON files (*.json)|*json|Text files (*.txt)|*txt";
                saveFile.ShowDialog();
                string name = saveFile.FileName;
                using StreamWriter streamWriter = new StreamWriter(name);
                using JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
                jsonSerializer.Serialize(jsonWriter, undo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private OpenFileDialog openFile = new OpenFileDialog();
        public Undo Deserialisation()
        {
            Undo undo = new Undo();

            try
            {
                openFile.ShowDialog();
                string name = openFile.FileName;
                
                using FileStream fileStream = File.OpenRead(name);
                string streamReader = new StreamReader(fileStream).ReadToEnd();
                undo = JsonConvert.DeserializeObject<Undo>(streamReader,  settings);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return undo;
        }
    }
}
