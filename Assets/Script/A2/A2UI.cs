using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2UI : MonoBehaviour
{
    public GameObject drug1UI;
    public GameObject drug2UI;
    public GameObject drug3UI;

    void Start()
    {
        drug1UI.SetActive(false);
        drug2UI.SetActive(false);
        drug3UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Level2.drug1 == true) drug1UI.SetActive(true);
        if (Level2.drug2 == true) drug2UI.SetActive(true);
        if (Level2.drug3 == true) drug3UI.SetActive(true);

        if (Window.thisfinish == true)
        {
            drug1UI.SetActive(false);
            drug2UI.SetActive(false);
            drug3UI.SetActive(false);
        }
    }
}
