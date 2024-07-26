using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Gamemanager : MonoBehaviour
{

    public  Player player;
    public Transform genarator;
    public float xOffset;
    public float yOffset;

    public Transform Camera;

    private void Awake() {
        Instantiate(player,genarator.position,Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveCamera()
    {
        Camera.position += new Vector3(0,yOffset,0);
    }
}
