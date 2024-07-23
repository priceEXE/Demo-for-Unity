using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public GameObject doorLeft,doorRight,doorUp,doordown;

    public int stepStart;

    public int doornumber;
    public bool roomLeft,roomRight,roomUp,roomDown;
    void Start()
    {
        doorLeft.SetActive(roomLeft);
        doorRight.SetActive(roomRight);
        doorUp.SetActive(roomUp);
        doordown.SetActive(roomDown);
    }
    public void UpdateRoom(float xOffset,float yOffset)
    {
        stepStart = (int)(Mathf.Abs(transform.position.x/6) + Mathf.Abs(transform.position.y / 2.9f));
        if(roomUp) doornumber++;
        if(roomDown) doornumber++;
        if(roomLeft)    doornumber++;
        if(roomRight)   doornumber++;

    }
    
}
