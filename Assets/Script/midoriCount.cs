using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class midoriCount : MonoBehaviour
{
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("midori").Length;
        //Debug.Log(); 
        this.GetComponent<Text>().text = count.ToString();
    }
}
