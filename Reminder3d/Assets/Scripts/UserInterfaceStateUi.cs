using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System;

namespace Reminder3d
{

    class UserInterfaceStateUi : AbstractUserInterface
    {
        public override void Hide()
        {
            gameObject.SetActive(false);
        }

        public override void Show(bool visible = true)
        {
            gameObject.SetActive(visible);
        }
    }
}
