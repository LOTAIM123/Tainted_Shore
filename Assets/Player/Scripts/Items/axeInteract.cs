using System;
using UnityEngine;

public class axeInteract : MonoBehaviour
{
    public Transform hand;


    void Update()
    {
        Debug.Log("yo");
        if(Input.GetKeyDown(KeyCode.G)) Debug.Log("Yo");
    }

    public void ItemInHandCheck()
    {   

        if(hand.childCount > 0)
        {
            print("YO");
        }
    }
}
