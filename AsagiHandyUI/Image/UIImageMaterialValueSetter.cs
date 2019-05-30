using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageMaterialValueSetter : MonoBehaviour
{
    [SerializeField]
    GameObject target = null;

    [SerializeField]
    string targetMaterialValueName = "";

    //TODO 複数型に対応
    [SerializeField]
    float val = 0;

    RawImage targetRaw;
    Image targetImage;

    float lastValue;

    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        targetRaw = target.GetComponent<RawImage>();
        if (targetRaw != null)
        {
            mat = targetRaw.material;
        }
        else
        {
            targetImage = target.GetComponent<Image>();
            mat = targetImage.material;
        }

        lastValue = val;
    }

    // Update is called once per frame
    void Update()
    {
        if(lastValue != val)
        {
            mat.SetFloat(targetMaterialValueName, val);
            lastValue = val;
        }
    }
}
