using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System;

namespace Reminder3d
{

    public class UserInterfaceManager : MonoBehaviour
    {
        List<AbstractUserInterface> interfaces = new List<AbstractUserInterface>();
        [SerializeField]
        EInterfaceState current = EInterfaceState.Main;
        void Awake()
        {
            interfaces.AddRange(gameObject.GetComponentsInChildren<AbstractUserInterface>());
            UpdateUI();
        }

        private void UpdateUI()
        {
            foreach (var i in interfaces)
            {
                i.Show(i.supported == current);
            }
        }

        public void ToCreate()
        {
            current = EInterfaceState.Create;
            UpdateUI();
        }

        public void ToMain()
        {
            current = EInterfaceState.Main;
            UpdateUI();
        }

        public void ApplyCreate()
        {
            current = EInterfaceState.Main;
            UpdateUI();
        }
    }
}
