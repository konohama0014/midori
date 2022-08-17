using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoomOut : MonoBehaviour
{
    Slider zoomSlider;

    public GameObject mainCamObj;

    float zoomPosi;
    // Start is called before the first frame update
    void Start()
    {
        zoomSlider = GetComponent<Slider>();

        float zoomMax = -10f;
        float zoomMin = -100f;

        //zoomSlider.maxValue = -10f;
        //zoomSlider.value = -10f;

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void touchZoomOut()
    {
        mainCamObj.transform.position = new Vector3(0, 0, -100);
    }

    public void touchZoomIn()
    {
        mainCamObj.transform.position = new Vector3(0, 0, -10);
    }

    public void zoomSlider_ontime()
    {
        mainCamObj.transform.position = new Vector3(0, 0, zoomSlider.value);
    }

}
