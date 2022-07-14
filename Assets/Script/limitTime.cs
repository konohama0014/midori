using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class limitTime : MonoBehaviour
{
    private Text limitTimeText;
    private float limit = 30f;
    public GameObject ResultPanel;

    // Start is called before the first frame update
    void Start()
    {
        limitTimeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(limit >= 0f )
        {
            limit -= Time.deltaTime;
            this.limitTimeText.GetComponent<Text>().text = "�̎�܂Ŏc��\n" + limit.ToString("00");
        }
        else
        {
            this.limitTimeText.GetComponent<Text>().text = "�̎抮���I";
            ResultPanel.SetActive(true);
        }

    }



}
