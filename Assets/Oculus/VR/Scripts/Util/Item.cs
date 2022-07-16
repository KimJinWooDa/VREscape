using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isSlot;
    public Vector3 slotRotation = Vector3.zero;
    public Slot currentSlot;

    public enum itemState { 기계심장, 지푸라기, 용기물약 };
    itemState IS;

    public void GetItem()
    {
        switch (IS)
        {
            case itemState.기계심장:
                break;
            case itemState.지푸라기:
                break;
            case itemState.용기물약:
                break;
            default:
                break;
        }
    }
}
