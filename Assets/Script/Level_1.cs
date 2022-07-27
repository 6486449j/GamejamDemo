using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    // 表世界的所有对象的父对象
    public GameObject apperance;
    // 里世界
    public GameObject _internal;
    // 第一个传送门 接待大厅的出口 从表世界切换至里世界
    public BoxCollider2D protal1;
    // 第二个传送门 售票站前方 从里世界切换至表世界
    public BoxCollider2D protal2;
    // 大门 离开场景处
    public BoxCollider2D gate;

    bool isInApperance = true;

    void Start()
    {
        _internal.SetActive(false);
    }

    void Update()
    {
        if (protal1.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            switchToI();
        }
        if (protal2.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            switchToA();
        }
    }

    void switchToA()
    {
        if (!isInApperance)
        {
            _internal.SetActive(false);
            apperance.SetActive(true);
            Debug.Log("表世界");
            isInApperance = true;
        }
    }

    void switchToI()
    {
        if (isInApperance)
        {
            apperance.SetActive(false);
            _internal.SetActive(true);
            Debug.Log("里世界");
            isInApperance = false;
        }
    }
}
