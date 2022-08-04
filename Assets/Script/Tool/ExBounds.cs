using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class ExBounds : MonoBehaviour
{
    // Start is called before the first frame update
    public static ExBounds Instance;
    public CinemachineConfiner cmc;
    public PolygonCollider2D defaults;

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
        cmc.m_BoundingShape2D = defaults;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setBound(PolygonCollider2D pc2d) => cmc.m_BoundingShape2D = pc2d;
}
