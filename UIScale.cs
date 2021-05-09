using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScale : MonoBehaviour
{
    public float resoX;
    public float resoY;

    private CanvasScaler canva;
    // Start is called before the first frame update
    void Start()
    {
        canva = GetComponent<CanvasScaler>();
        SetInfo();
    }

    private void SetInfo()
    {
        resoX = (float)Screen.currentResolution.width;
        resoY = (float)Screen.currentResolution.height;


        canva.referenceResolution = new Vector2(resoX, resoY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
