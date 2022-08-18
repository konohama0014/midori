using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Changemainsene()
    {
        transform.DOScale(1.1f, 0.5f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            SceneManager.LoadScene("mainsene");
        });
    }

    public void Changeintro()
    {
        transform.DOScale(1.1f, 0.5f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            SceneManager.LoadScene("intro");
        });
    }

}
