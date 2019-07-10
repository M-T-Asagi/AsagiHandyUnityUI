using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DebugLogViewerContentSetter : MonoBehaviour
{
    [SerializeField]
    Text time = null;
    [SerializeField]
    Text main = null;
    [SerializeField]
    UnityEvent OnUpdate;

    public void UpdateText(string _time, string _main)
    {
        time.text = _time;
        main.text = _main;
        if (OnUpdate != null)
            OnUpdate.Invoke();
    }
}
