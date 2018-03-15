using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System;

namespace Reminder3d
{

    public class JsonManager
    {
        const string BASE_PATH = "";

        public static T Get<T>(string item) where T : JBase
        {
            string path = GetPath(item);
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path, Encoding.UTF8);
                return JsonConvert.DeserializeObject<T>(text);
            }
            else
            {
                Debug.LogError("Config does not exist at " + path);
            }
            return null;
        }

        private static string GetPath(string item)
        {
            return PathExtension.Combine(Application.persistentDataPath, BASE_PATH, item + ".json");
        }

        internal static void Save<T>(T obj, string item) where T : JBase
        {
            File.WriteAllText(GetPath(item), JsonConvert.SerializeObject(obj), Encoding.UTF8);
        }
    }
}
