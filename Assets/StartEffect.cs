using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEffect : MonoBehaviour
{
    public GameObject Light;
    public AudioSource AS;
    public GameObject[] particles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(StartingEffect());
        }
    }

    IEnumerator StartingEffect()
    {
        Light.SetActive(false);
        yield return new WaitForSeconds(1f);
        AS.Play();
        yield return new WaitForSeconds(1f);
        Light light = Light.GetComponentInChildren<Light>();
        light.gameObject.SetActive(false);
        for(int i = 0; i < particles.Length; i++)
        {
            particles[i].SetActive(true);
        }
    }
}
