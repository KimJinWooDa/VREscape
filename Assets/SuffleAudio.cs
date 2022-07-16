using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuffleAudio : MonoBehaviour
{
    public AudioSource AS;

    public AudioClip[] AC;

    private void Awake()
    {
        AS = GetComponent<AudioSource>();
        StartCoroutine(StartBGM());
    }

    IEnumerator StartBGM()
    {
        yield return new WaitForSeconds(10f);
        SuffleRandomBGM();
    }
    void SuffleRandomBGM()
    {
        int randomValue = Random.Range(0, AC.Length);
        AS.clip = AC[randomValue];
        AS.Play();
    }
}
