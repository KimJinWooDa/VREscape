using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTheWaitingRoom : MonoBehaviour
{
    public GameObject door;
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.GetComponentInChildren<AudioSource>().Play();
            StartCoroutine(OFFSound());
        }
    }

    IEnumerator OFFSound()
    {
        yield return new WaitForSeconds(5f);
        door.GetComponentInChildren<AudioSource>().Pause();
    }
}
