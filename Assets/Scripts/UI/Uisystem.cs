using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uisystem : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OptionSetActive()
    {
        Debug.Log("显示局内设置");
    }

    public void ResumeGameActive()
    {
        Debug.Log("重新开始游戏");
    }

    public void ExitGameActive()
    {
        Debug.Log("退出当前游戏");
    }
}
