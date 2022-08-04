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

    void Start()
    {
        // crossfade.gameObject.SetActive(true);
    }

    public IEnumerator switchToA()
    {
        if (!isInApperance)
        {
            crossfade.gameObject.SetActive(true);
            crossfade.SetTrigger("Start");
            yield return new WaitForSeconds(0.5f);
            _internal.SetActive(false);
            apperance.SetActive(true);
            Debug.Log("表世界");
            isInApperance = true;
            crossfade.SetTrigger("End");
            crossfade.gameObject.SetActive(false);
        }
    }

    public IEnumerator switchToI()
    {
        if (isInApperance)
        {
            crossfade.gameObject.SetActive(true);
            crossfade.SetTrigger("Start");
            yield return new WaitForSeconds(0.5f);
            apperance.SetActive(false);
            _internal.SetActive(true);
            Debug.Log("里世界");
            isInApperance = false;
            crossfade.SetTrigger("End");
            crossfade.gameObject.SetActive(false);
        }
    }
}
