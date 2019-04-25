using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class victoryscreech : MonoBehaviour
{
    public AudioSource Fantasy;

    public AudioClip FF;
    // Start is called before the first frame update
    void Awake()
    {
        Fantasy = GetComponent<AudioSource>();
        Fantasy.PlayOneShot(FF);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    
}
