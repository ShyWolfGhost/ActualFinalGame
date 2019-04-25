using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiPianobg : MonoBehaviour
{
    public AudioSource Lppl;
    public AudioClip PianoCov;
    // Start is called before the first frame update
    void Start()
    {
        Lppl = GetComponent<AudioSource>();
        Lppl.PlayOneShot(PianoCov);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
