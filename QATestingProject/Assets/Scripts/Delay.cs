using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    //VARS
    public AudioSource AudioSource;
        
    void Start()
    {
        AudioSource.PlayDelayed(3);  
    }
}
