using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1Footstep : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource main;

    public AudioClip grass1;
    public AudioClip floor;

    public static A1Footstep Instance;

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
        main.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void initgrass() => main.clip = grass1;
    public void initfloor() => main.clip = floor;
}
