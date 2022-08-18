using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class toweenTitle : MonoBehaviour
{

    //private DOTweenTMPAnimator tmpAnimator;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI tmpro = GetComponent<TextMeshProUGUI>();
        tmpro.DOFade(0, 0);

        DOTweenTMPAnimator tmproAnimator = new DOTweenTMPAnimator(tmpro);

        for (int i = 0; i < tmproAnimator.textInfo.characterCount; ++i)
        {
            tmproAnimator.DOScaleChar(i, 0.1f, 0);
            Vector3 currCharOffset = tmproAnimator.GetCharOffset(i);
            DOTween.Sequence()
                .Append(tmproAnimator.DOOffsetChar(i, currCharOffset + new Vector3(0, 10, 0), 0.8f).SetEase(Ease.OutFlash, 2))
                .Join(tmproAnimator.DOFadeChar(i, 1, 0.8f))
                .Join(tmproAnimator.DOScaleChar(i, 1, 0.8f).SetEase(Ease.OutBack))
                .SetDelay(0.1f * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }





}
