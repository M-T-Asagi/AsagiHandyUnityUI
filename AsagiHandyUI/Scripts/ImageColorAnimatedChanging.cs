using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AsagiHandy.UI.Generic
{
    public class ImageColorAnimatedChanging : MonoBehaviour
    {
        [SerializeField]
        Image image = null;

        [SerializeField]
        Color color1 = Color.white;

        [SerializeField]
        Color color2 = Color.black;

        [SerializeField]
        float useTime = 1f;

        [SerializeField]
        Color defaultColor = Color.white;

        bool changing = false;
        float startChangeTime = 0;
        Color fromColor;
        Color toColor;

        // Start is called before the first frame update
        void Start()
        {
            image.color = defaultColor;
        }

        public void ColorChange(bool changeTo1)
        {
            if (changeTo1)
                ColorChangeTo1();
            else
                ColorChangeTo2();
        }

        public void ColorChangeTo1()
        {
            StartColorChanging(color2, color1);
        }

        public void ColorChangeTo2()
        {
            StartColorChanging(color1, color2);
        }

        void StartColorChanging(Color from, Color to)
        {
            fromColor = from;
            toColor = to;
            startChangeTime = Time.time;
            changing = true;
        }

        void Update()
        {
            if(changing)
            {
                float state = (Time.time - startChangeTime) / useTime;
                UpdateColor(state);
                changing = (state < 1);
            }
        }

        void UpdateColor(float state)
        {
            image.color = Color.Lerp(fromColor, toColor, Mathf.Min(state, 1f));
        }
    }
}