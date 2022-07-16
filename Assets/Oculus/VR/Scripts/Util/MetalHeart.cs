using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalHeart : MonoBehaviour
{
    public AudioSource AS;
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("AddPitchSpeed");
        }
    }

    IEnumerator AddPitchSpeed()
    {
        while (AS.pitch < 3f)
        {
            yield return null;
            AS.pitch += 0.2f;
        } 
    }
    void Update()
    {
        
    }
}
