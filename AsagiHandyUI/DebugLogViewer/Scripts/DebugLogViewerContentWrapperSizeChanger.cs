using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogViewerContentWrapperSizeChanger : MonoBehaviour
{
    [SerializeField]
    RectTransform contentWrapper = null;

    public void UpdateContentWrapperSize()
    {
        float height = 0;
        foreach(RectTransform content in contentWrapper)
        {
            height += content.sizeDelta.y;
        }
        contentWrapper.sizeDelta = new Vector2(contentWrapper.sizeDelta.x, Mathf.Max(height, contentWrapper.parent.GetComponent<RectTransform>().sizeDelta.y));
    }
}
