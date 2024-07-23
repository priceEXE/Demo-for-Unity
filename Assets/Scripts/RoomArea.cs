using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomArea : MonoBehaviour
{
        public bool isArrived = false;

        private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player") && isArrived == false)  {
            isArrived =true;
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
        
    }
}
