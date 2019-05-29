using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AsagiHandy.UI.ToggleController
{
    public class ToggleAnimationController : MonoBehaviour
    {
        [SerializeField]
        Toggle toggle = null;
        [SerializeField]
        Animator targetAnimator = null;

        // Start is called before the first frame update
        void Start()
        {
            targetAnimator.SetBool("isOn", toggle.isOn);
            toggle.onValueChanged.AddListener(ToggleValueChange);
        }

        void ToggleValueChange(bool isOn)
        {
            targetAnimator.SetBool("isOn", isOn);
        }

    }
}