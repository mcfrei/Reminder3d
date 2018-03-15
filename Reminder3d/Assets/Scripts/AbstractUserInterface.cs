using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System;

namespace Reminder3d
{

    abstract class AbstractUserInterface : MonoBehaviour
    {
        [SerializeField]
        public EInterfaceState supported;

        public abstract void Show(bool visible);
        public abstract void Hide();
    }
}
