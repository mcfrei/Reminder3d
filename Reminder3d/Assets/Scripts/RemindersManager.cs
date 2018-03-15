using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System;

namespace Reminder3d
{
    public class RemindersManager : MonoBehaviour
    {
        private JRemindersList reminders;

        void Awake()
        {
            LoadReminders();
        }

        private void LoadReminders()
        {
            reminders = JsonManager.Get<JRemindersList>(JRemindersList.PATH);
            if (reminders != null && reminders.list != null)
            {
                foreach (var reminder in reminders.list)
                    ReminderView.Create(reminder, transform);
            }
            else
            {
                reminders = new JRemindersList();
                SaveReminders();
            }
        }

        public void SaveReminders()
        {
            JsonManager.Save(reminders, JRemindersList.PATH);
        }
    }
}
