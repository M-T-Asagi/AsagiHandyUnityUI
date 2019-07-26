using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AsagiHandy.UI.DebugLogViewer
{
    public class DebugLogScrollerPositionFitter : MonoBehaviour
    {
        [SerializeField]
        ScrollRect scrollRect = null;

        float lastPosition = 0f;

        public void positionUpdate(Vector2 position)
        {
            lastPosition = position.y;
        }

        public void PositionFitting()
        {
            if (lastPosition <= 0.001f || lastPosition >= 0.999f)
            {
                Vector2 newPos = scrollRect.normalizedPosition;
                newPos.y = Mathf.Round(newPos.y);
                scrollRect.normalizedPosition = newPos;
            }
        }
    }
}