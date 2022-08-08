using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class A2BoundList : MonoBehaviour
{
    // Start is called before the first frame update
    //public CinemachineConfiner cmc;

    public PolygonCollider2D entrance_;
    public PolygonCollider2D hospital_;
    public PolygonCollider2D assult_;
    public PolygonCollider2D room_;
    public PolygonCollider2D mission_;
    public PolygonCollider2D ExitBound_;

    public static A2BoundList Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    void Start()
    {
        //cmc.m_BoundingShape2D = entrance_;
    }

    public void hospital() => ExBounds.Instance.setBound(hospital_);
    public void assult() => ExBounds.Instance.setBound(assult_);
    public void room() => ExBounds.Instance.setBound(room_);
    public void mission() => ExBounds.Instance.setBound(mission_);
    public void exit() => ExBounds.Instance.setBound(ExitBound_);
}
