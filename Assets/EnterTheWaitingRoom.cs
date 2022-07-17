using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTheWaitingRoom : MonoBehaviour
{
    public GameObject door;
    bool isOnce;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOnce)
        {
            door.GetComponentInChildren<AudioSource>().Play();
            StartCoroutine(OFFSound());
            isOnce = true;
        }
    }

    IEnumerator OFFSound()
    {
        yield return new WaitForSeconds(5f);
        door.GetComponentInChildren<AudioSource>().Pause();
    }
}
