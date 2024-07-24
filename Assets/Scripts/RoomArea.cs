using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomArea : MonoBehaviour
{
    public door door_up,door_down,door_left,door_right;
        public bool isArrived = false;
        public bool isCleaned = false;

        private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player") && !isArrived)  {
            isArrived =true;
            InitializeRoom(door_up);
            InitializeRoom(door_down);
            InitializeRoom(door_left);
            InitializeRoom(door_right);
            Debug.Log("生成敌人");
        }
        
        }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isArrived && isCleaned)
            {
            openGate(door_up);
            openGate(door_down);
            openGate(door_left);
            openGate(door_right);
        }
    }
    private void InitializeRoom(door door)
    {
        door.openDoor.SetActive(false);
        door.closeDoor.SetActive(true);
    }
    private void openGate(door door)
    {
        door.openDoor.SetActive(true);
        door.closeDoor.SetActive(false);
    }
}
