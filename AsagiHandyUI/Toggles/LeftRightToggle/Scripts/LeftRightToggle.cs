using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AsagiHandy.UI
{
    public class LeftRightToggle : MonoBehaviour
    {
        [SerializeField]
        Toggle toggle = null;
        [SerializeField]
        Animator animator = null;

        // Start is called before the first frame update
        void Start()
        {
            animator.SetBool("isOn", toggle.isOn);
            toggle.onValueChanged.AddListener(ToggleValueChange);
        }

        void ToggleValueChange(bool isOn)
        {
            animator.SetBool("isOn", isOn);
        }

    }
}