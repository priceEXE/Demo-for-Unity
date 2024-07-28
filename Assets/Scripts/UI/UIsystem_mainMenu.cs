using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIsystem_mainMenu : MonoBehaviour
{
    private float loading_progress;
    public GameObject loading;//加载场景
    public Image Volumn_image;//音量显示面
    public Sprite[] Volumn;//音量贴图
    public int volume_value=5;//音量值
    public GameObject BGM;//挂载BGM声源
    private bool isSetiingGame = false;//是否处于开始面
    public Animator titlePanel;//标题面动画器
    public Animator SettingPenel;//开始面动画器

    public Animator OptionPanel;//设置面动画器
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //同步音量值
        updateVolumn();
    }
    //进入开始游戏面
    public void StartGame()
    {
        isSetiingGame = true;
        titlePanel.SetBool("CouldActive",isSetiingGame);
        SettingPenel.SetBool("CouldActive",isSetiingGame);
    }
    //返回标题面
    public void Return()
    {
        isSetiingGame = false;
        titlePanel.SetBool("CouldActive",isSetiingGame);
        SettingPenel.SetBool("CouldActive",isSetiingGame);
    }
    //进入设置面
    public void OptionPanelActive()
    {
        SettingPenel.SetBool("Option",true);
        OptionPanel.SetBool("CouldActive",true);
    }
    //返回开始面
    public void ReturnOptionPanel()
    {
        SettingPenel.SetBool("Option",false);
        OptionPanel.SetBool("CouldActive",false);
    }
    //增大音量
    public void AddVolumn()
    {
        if(volume_value<10)
        {
            volume_value += 1 ;
            Volumn_image.sprite = Volumn[10-volume_value];
        }

    }
    //减小音量
    public void ReduceVolumn()
    {
        if(volume_value>0)
        {
            volume_value -= 1;
            Volumn_image.sprite = Volumn[10-volume_value];
        }
    }
    //更新音量值
    public void updateVolumn()
    {
        BGM.GetComponent<AudioSource>().volume = volume_value*0.1f;
    }

    public void StartLevel()
    {
        StartCoroutine(Loadlevel());
    }

    //异步加载携程
    IEnumerator  Loadlevel()
    {
        loading.SetActive(true);
        AsyncOperation asyncload = SceneManager.LoadSceneAsync("Game");
        asyncload.allowSceneActivation = true;
        while(!asyncload.isDone)
        {
            loading_progress +=asyncload.progress * Time.deltaTime/10f;
            if(loading_progress>0.99f)  asyncload.allowSceneActivation = true;
            yield return null;
        }
    }
}
