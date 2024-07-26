using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RoomGenarator : MonoBehaviour
{
    public enum Direction{ up,down,left,right};
    public enum RoomId{Normal,Award,Boss};
    public Direction direction;
    [Header("房间信息")]
    public Room Normal,Award,Boss;
    public int roomNumber;
    private GameObject endRoom;


    [Header("位置控制")]
    public Transform generatorpoint;
    public float xOffset;
    public float yOffset;
    public LayerMask roomlayer;
    public int maxStep;

    public List<Room> rooms = new List<Room>();


    List<GameObject> farRoom = new List<GameObject>();
    List<GameObject> lessFarRoom = new List<GameObject>();
    List<GameObject> oneWayRoom = new List<GameObject>();
    
    void Start()
    {
        //生成房间
        /*for(int i=0;i<roomNumber;i++)
        {
            if(i==0)
            {
                rooms.Add(Instantiate(Normal, generatorpoint.position,Quaternion.identity).GetComponent<Room>());    
            }
            else if(i==roomNumber-1)
            {
                rooms.Add(Instantiate(Boss, generatorpoint.position,Quaternion.identity).GetComponent<Room>());
            }
            else    {
                rooms.Add(Instantiate(Normal, generatorpoint.position,Quaternion.identity).GetComponent<Room>());
            }
            ChangePoint();
        }*/
        /*foreach(var room in rooms)
        {
            SetupRoom(room,room.transform.position);
        }*/

        //创建Boss房

        //FindEndRoom();
    }

    //设置房间
    

    //寻找单门最远房间
/*    public void FindEndRoom()
    {
        for(int i=0;i<rooms.Count;i++)
        {
            if(rooms[i].stepStart > maxStep)
                maxStep = rooms[i].stepStart;
        }

        foreach(var room in rooms)
        {
            if(room.stepStart == maxStep)
                farRoom.Add(room.gameObject);
            if(room.stepStart == maxStep-1)
                lessFarRoom.Add(room.gameObject);
        }

        for(int i=0;i< farRoom.Count;i++)
        {
            if(farRoom[i].GetComponent<Room>().doornumber==1)
                oneWayRoom.Add(farRoom[i]);
        }
        for(int i=0;i< lessFarRoom.Count;i++)
        {
            if(lessFarRoom[i].GetComponent<Room>().doornumber==1)
                oneWayRoom.Add(lessFarRoom[i]);
        }
        if(oneWayRoom.Count==0)
        {
            endRoom = oneWayRoom[UnityEngine.Random.Range(0,oneWayRoom.Count)];
        }
        else{
            endRoom = farRoom[UnityEngine.Random.Range(0,farRoom.Count)];
        }
    }*/

    //更改生成点位置
 /*   public void ChangePoint()
    {
        do{
        direction = (Direction)UnityEngine.Random.Range(0,4);
        switch(direction)
        {
            case Direction.up:
                generatorpoint.position += new Vector3(0,yOffset,0);
                break;
            case Direction.down:
                generatorpoint.position += new Vector3(0,-yOffset,0);
                break;
            case Direction.left:
                generatorpoint.position += new Vector3(-xOffset,0,0);
                break;
            case Direction.right:
                generatorpoint.position += new Vector3(xOffset,0,0);
                break;
        }
        }while(Physics2D.OverlapCircle(generatorpoint.position,0.2f,roomlayer));
    }*/
}

/*
[System.Serializable]
public class RoomType
{
    public enum RoomId{Normal,Award,Boss}
    public GameObject Normal,Award,Boss;
}*/