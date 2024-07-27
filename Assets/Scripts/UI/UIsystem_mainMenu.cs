using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIsystem_mainMenu : MonoBehaviour
{
    private bool isSetiingGame = false;
    public Animator titlePanel;
    public Animator SettingPenel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && isSetiingGame)
        {
            Debug.Log("返回标题面");
            isSetiingGame = false;
            titlePanel.SetBool("CouldActive",isSetiingGame);
            SettingPenel.SetBool("CouldActive",isSetiingGame);
        }
    }

    public void StartGame()
    {
        isSetiingGame = true;
        Debug.Log("strat game");
        titlePanel.SetBool("CouldActive",isSetiingGame);
        SettingPenel.SetBool("CouldActive",isSetiingGame);

        
    }
}
