using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Issac : MonoBehaviour
{
    public int speed = 5;
    public int bulletSpeed = 1;
    private float health = 3;
    public float attck_length;

    public float shootFrequecy = 0.1f;
    private float invoketime;
    private bool isShooting_left = false;
    private bool isShooting_right = false;
    private bool isShooting_up = false;
    private bool isShooting_down = false;
    public Animator animator_body;
    public Animator animator_head;
    private Rigidbody2D _Rigbody;
    // Start is called before the first frame update
    void Start()
    {
        _Rigbody = GetComponent<Rigidbody2D>();
        invoketime = shootFrequecy;
    }

    // Update is called once per frame
    void Update()
    {
        //获取玩家上下左右的输入值
        float horizontalValue = Input.GetAxis("Horizontal_SelfDefine");
        float verticalValue = Input.GetAxis("Vertical_SelfDefine");
        //改变动画状态
        animator_body.SetFloat("Horizontal",horizontalValue);
        animator_head.SetFloat("Horizontal",horizontalValue);
        animator_body.SetFloat("Vertical",verticalValue);
        animator_head.SetFloat("Vertical",verticalValue);
        //改变物体的速度
        _Rigbody.velocity = new Vector2(speed * horizontalValue,speed * verticalValue);
        //攻击间隔及键位冲突判定
        if(Input.GetKey(KeyCode.LeftArrow) && !isShooting_down && !isShooting_right && !isShooting_up)
        {
            //向左射击
            isShooting_left = true;
            invoketime += Time.deltaTime;
            if(invoketime >shootFrequecy )  
            {
                animator_head.SetBool("isShooted-left",true);
                Debug.Log("向左攻击");
                invoketime = 0f;
            }
        }
        if(Input.GetKey(KeyCode.RightArrow) && !isShooting_left && !isShooting_up && !isShooting_down)
        {
            //向右射击
            isShooting_right = true;
            invoketime += Time.deltaTime;
            if(invoketime >shootFrequecy )  
            {
                animator_head.SetBool("isShooted-right",true);
                Debug.Log("向you攻击");
                invoketime = 0f;
            }
        }
        if(Input.GetKey(KeyCode.UpArrow) && !isShooting_down && !isShooting_left && !isShooting_right)
        {
            //向上射击
            isShooting_up = true;
            invoketime += Time.deltaTime;
            if(invoketime > shootFrequecy)
            {
                animator_head.SetBool("isShooted-up",true);
                Debug.Log("向上攻击");
                invoketime = 0f;
            }
        }
        if(Input.GetKey(KeyCode.DownArrow) && !isShooting_left && !isShooting_right && !isShooting_up)
        {
            //向下射击
            isShooting_down = true;
            invoketime += Time.deltaTime;
            if(invoketime > shootFrequecy)
            {
                animator_head.SetBool("isShooted-down",true);
                Debug.Log("向下攻击");
                invoketime = 0f;
            }    
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow) )
        {
            invoketime = shootFrequecy;
            isShooting_left = false;
            animator_head.SetBool("isShooted-left",false);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            invoketime = shootFrequecy;
            isShooting_right = false;
            animator_head.SetBool("isShooted-right",false);
        }
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            invoketime = shootFrequecy;
            isShooting_up = false;
            animator_head.SetBool("isShooted-up",false);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            invoketime = shootFrequecy;
            isShooting_down = false;
            animator_head.SetBool("isShooted-down",false);
        }
    }
}
