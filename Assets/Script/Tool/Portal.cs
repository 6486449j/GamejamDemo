using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Portal : MonoBehaviour
{
    public static Portal Instance;
    public CinemachineConfiner cmc; 
    public PolygonCollider2D defaults;

    public bool isTrigger = false;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

        }
    }

    public void setBound(PolygonCollider2D pc2d) => cmc.m_BoundingShape2D = pc2d;
}
