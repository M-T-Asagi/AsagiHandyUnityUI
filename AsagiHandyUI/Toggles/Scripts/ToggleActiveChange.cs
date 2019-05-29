using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AsagiHandy.UI.ToggleController
{
    public class ToggleActiveChange : MonoBehaviour
    {
        [SerializeField]
        Toggle toggle = null;

        [SerializeField]
        GameObject targetObject = null;

        [SerializeField]
        bool reverseToggleValue = false;

        // Start is called before the first frame update
        void Start()
        {
            this.SetActive(toggle.isOn);
            toggle.onValueChanged.AddListener(HandleUnityAction);
        }

        void HandleUnityAction(bool isOn)
        {
            this.SetActive(isOn);
        }

        void SetActive(bool isOn)
        {
            targetObject.SetActive(isOn != reverseToggleValue);
        }
    }
}