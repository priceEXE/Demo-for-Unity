using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject enamy;
    public RoomGenarator roomGenarator;
    public GameObject doorLeft,doorRight,doorUp,doordown,walldoor;

    public int stepStart;

    public int doornumber;
    public bool roomLeft,roomRight,roomUp,roomDown;
    void Start()
    {
        Room room = GetComponent<Room>();
        Transform transform = GetComponent<Transform>();
        SetupRoom(room,transform.position);
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
    public void SetupRoom(Room newroom, Vector3 roomposition)
    {
        //生成门
        newroom.roomUp = Physics2D.OverlapCircle(roomposition + new Vector3(0,roomGenarator.yOffset,0),0.2f,roomGenarator.roomlayer);
        newroom.roomDown = Physics2D.OverlapCircle(roomposition + new Vector3(0,-roomGenarator.yOffset,0),0.2f,roomGenarator.roomlayer);
        newroom.roomLeft = Physics2D.OverlapCircle(roomposition + new Vector3(-roomGenarator.xOffset,0,0),0.2f,roomGenarator.roomlayer);
        newroom.roomRight = Physics2D.OverlapCircle(roomposition + new Vector3(roomGenarator.xOffset,0,0),0.2f,roomGenarator.roomlayer);
        newroom.UpdateRoom(roomGenarator.xOffset,roomGenarator.yOffset);
    }
    
}

