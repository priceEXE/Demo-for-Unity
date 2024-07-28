using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIsystem_mainMenu : MonoBehaviour
{
    public Image Volumn_image;
    public Sprite[] Volumn;
    public int volume_value=5;
    public GameObject BGM;
    private bool isSetiingGame = false;
    public Animator titlePanel;
    public Animator SettingPenel;

    public Animator OptionPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateVolumn();
    }

    public void StartGame()
    {
        isSetiingGame = true;
        Debug.Log("strat game");
        titlePanel.SetBool("CouldActive",isSetiingGame);
        SettingPenel.SetBool("CouldActive",isSetiingGame);
    }

    public void Return()
    {
        Debug.Log("返回标题面");
        isSetiingGame = false;
        titlePanel.SetBool("CouldActive",isSetiingGame);
        SettingPenel.SetBool("CouldActive",isSetiingGame);
    }

    public void OptionPanelActive()
    {
        SettingPenel.SetBool("Option",true);
        OptionPanel.SetBool("CouldActive",true);
    }

    public void ReturnOptionPanel()
    {
        SettingPenel.SetBool("Option",false);
        OptionPanel.SetBool("CouldActive",false);
    }

    public void AddVolumn()
    {
        if(volume_value<10)
        {
            volume_value += 1 ;
            Volumn_image.sprite = Volumn[10-volume_value];
        }

    }

    public void ReduceVolumn()
    {
        if(volume_value>0)
        {
            volume_value -= 1;
            Volumn_image.sprite = Volumn[10-volume_value];
        }
    }

    public void updateVolumn()
    {
        BGM.GetComponent<AudioSource>().volume = volume_value*0.1f;
    }
}
