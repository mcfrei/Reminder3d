using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reminder3d
{
    abstract public class ReminderView : MonoBehaviour
    {
        JReminder data;
        [SerializeField]
        TextMesh text;
        [SerializeField]
        new Renderer renderer;
        [SerializeField]
        string colorPropertyName = "_Color";

        public static void Create(JReminder data, Transform parent)
        {
            var go = new GameObject(data.name, typeof(ReminderView));
            go.transform.SetParent(parent, false);
            var rem = go.GetComponent<ReminderView>();
            rem.InitWith(data);
        }

        private void InitWith(JReminder data)
        {
            this.data = data;
            SetColor(data.color);
            SetText(data.message);
        }

        private void SetText(string message)
        {
            if (text == null)
            {
                Debug.LogWarning("text == null");
            }
            else
            {
                text.text = message;
            }
        }

        private void SetColor(Color color)
        {
            if (renderer == null)
            {
                Debug.LogWarning("renderer == null");
            }
            else
            {
                var mpb = new MaterialPropertyBlock();
                mpb.SetColor(colorPropertyName, data.color);
                renderer.SetPropertyBlock(mpb);
            }
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
