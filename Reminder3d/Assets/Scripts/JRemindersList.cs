using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reminder3d
{

    public class JRemindersList : JBase
    {
        public const string PATH = "reminders";
        [JsonProperty]
        public List<JReminder> list = new List<JReminder>();
    }
}
