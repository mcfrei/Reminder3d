using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reminder3d
{
    public abstract class JBase { }

    public class JReminder : JBase
    {
        [JsonProperty]
        public string name;
        [JsonProperty]
        public string message;
        [JsonProperty]
        public Color color;
    }
}
