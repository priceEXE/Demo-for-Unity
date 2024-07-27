using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Gamemanager : MonoBehaviour
{
    private bool isPauesed = false;
    public  Player player;
    public Transform genarator;
    public float xOffset;
    public float yOffset;

    public Transform Camera;

    public GameObject Paused_SettingPanel;

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
        if(Input.GetKeyDown(KeyCode.Escape) && !isPauesed)
        {
            Debug.Log("TimeFreesed");
            isPauesed = true;
            Time.timeScale = 0f;
            Paused_SettingPanel.SetActive(isPauesed);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPauesed)
        {
            Debug.Log("TimeUnfreezed");
            isPauesed = false;
            Time.timeScale = 1f;
            Paused_SettingPanel.SetActive(isPauesed);
        }
    }

    public void moveCamera()
    {
        Camera.position += new Vector3(0,yOffset,0);
    }
}
