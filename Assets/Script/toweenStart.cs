using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class toweenStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOScale(0.1f, 1f)
        .SetRelative(true)
        .SetEase(Ease.InOutQuad)
        .SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
