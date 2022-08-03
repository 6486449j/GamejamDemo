using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    // 表世界的所有对象的父对象
    public GameObject apperance;
    // 里世界
    public GameObject _internal;
    public Animator crossfade;

    bool isInApperance = true;

    public void switchToA()
    {
        if (!isInApperance)
        {
            StartCoroutine(switchEffect());
            _internal.SetActive(false);
            apperance.SetActive(true);
            Debug.Log("表世界");
            isInApperance = true;
            // sunny.SetActive(false);
        }
    }

    public void switchToI()
    {
        if (isInApperance)
        {
            StartCoroutine(switchEffect());
            apperance.SetActive(false);
            _internal.SetActive(true);
            Debug.Log("里世界");
            isInApperance = false;
        }
    }
    public IEnumerator switchEffect()
    {
        crossfade.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        crossfade.SetTrigger("End");
    }
}
