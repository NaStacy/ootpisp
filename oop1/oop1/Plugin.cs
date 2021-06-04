using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace oop1
{
    public class Plugin
    {
        private Dictionary<string, Type> pluginDictionary = new Dictionary<string, Type>();
        
        public string NewPlugin()
        {
            string pluginName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = @"File DLL (*.dll)|*.dll"
            };

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Assembly assembly = Assembly.LoadFrom(openFileDialog.FileName);
                    Type[] types = assembly.GetTypes();

                    foreach (Type type in types)
                    {
                        foreach (Attribute attribute in type.GetCustomAttributes())
                        {
                            if (attribute is FactoryAttribute factoryAttribute)
                            {
                                pluginDictionary.Add(factoryAttribute.TollName, type);
                                pluginName = factoryAttribute.TollName;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return pluginName;
        }

        public Type GetPlugin(string pluginName)
        {
            return pluginDictionary[pluginName];
        }
    }
}
