using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogViewerContentSizeChanger : MonoBehaviour
{
    [SerializeField]
    RectTransform debugLogViewerContentBox = null;
    [SerializeField]
    float minimumHeight = 40f;
    [SerializeField]
    float defaultMainTextHeight = 10f;
    [SerializeField]
    UnityEngine.UI.Text mainText = null;

    public void UpdateSize()
    {
        debugLogViewerContentBox.sizeDelta = new Vector2(debugLogViewerContentBox.sizeDelta.x, minimumHeight + defaultMainTextHeight + mainText.preferredHeight);
    }
}
