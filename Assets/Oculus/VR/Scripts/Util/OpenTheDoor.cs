using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    public GameObject door;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            for (int i = 0; i < GameManager.Instance.isTrueObjects.Length; i++)
            {
                if (!GameManager.Instance.isTrueObjects[i]) return;


            }
            // ���� ���� ������
            door.GetComponentInChildren<AudioSource>().Pause();
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //���̵� �ƿ��ǰ� ���̵� �� �Ǹ鼭 �������� �߾�����
        }
    }
}
