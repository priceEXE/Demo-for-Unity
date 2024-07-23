using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    public float xOffset;
    public float yOffset;

    public Transform Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) moveCamera();
    }

    public void moveCamera()
    {
        Camera.position += new Vector3(0,yOffset,0);
    }
}
