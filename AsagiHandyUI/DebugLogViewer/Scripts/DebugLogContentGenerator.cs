using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DebugLogContentGenerator : MonoBehaviour
{
    static string DATETIME_FORMAT = "yyyy/MM/dd HH-mm-ss";

    [SerializeField]
    Transform parent = null;
    [SerializeField]
    GameObject logPrefab;
    [SerializeField]
    GameObject warningPrefab;
    [SerializeField]
    GameObject errorPrefab;
    [SerializeField]
    UnityEvent OnGeneratedContent = null;
    [SerializeField]
    bool viewLog = true;
    [SerializeField]
    bool viewWarning = true;
    [SerializeField]
    bool viewError = true;

    // Start is called before the first frame update
    void Start()
    {
        Application.logMessageReceived += Application_logMessageReceived;
    }

    private void Application_logMessageReceived(string condition, string stackTrace, LogType type)
    {
        switch (type)
        {
            case LogType.Log:
                if(viewLog)
                    AddContent(System.DateTime.Now.ToString(DATETIME_FORMAT), condition, logPrefab);
                break;
            case LogType.Warning:
                if(viewWarning)
                    AddContent(System.DateTime.Now.ToString(DATETIME_FORMAT), condition, warningPrefab);
                break;
            case LogType.Error:
                if(viewError)
                {
                    AddContent(System.DateTime.Now.ToString(DATETIME_FORMAT), condition, errorPrefab);
                    AddContent(System.DateTime.Now.ToString(DATETIME_FORMAT), stackTrace, errorPrefab);
                }
                break;
        }
        if (OnGeneratedContent != null)
            OnGeneratedContent.Invoke();
    }

    private void AddContent(string time, string main, GameObject prefab)
    {
        GameObject newObj = Instantiate(prefab, parent);
        newObj.GetComponent<DebugLogViewerContentSetter>().UpdateText(time, main);
    }
}
