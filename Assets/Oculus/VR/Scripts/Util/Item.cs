using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isSlot;
    public Vector3 slotRotation = Vector3.zero;
    public Slot currentSlot;

    public enum itemState { ������, ��Ǫ���, ��⹰�� };
    itemState IS;

    public void GetItem()
    {
        switch (IS)
        {
            case itemState.������:
                break;
            case itemState.��Ǫ���:
                break;
            case itemState.��⹰��:
                break;
            default:
                break;
        }
    }
}
