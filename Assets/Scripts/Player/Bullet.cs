using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Player player;
    public Rigidbody2D Rigidbody;
    // Start is called before the first frame update
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //子弹发射方向和速度
    public void SetSpeed(Vector2 direction)
    {
        Rigidbody.velocity = direction;
        StartCoroutine(DestroyObj(player.attck_length));
    }
    //子弹碰撞销毁
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Wall") || other.gameObject.CompareTag("Enamy") || other.CompareTag("Obstract"))
        {
            Destroy(gameObject);
        }
    }

    //定时销毁子弹实体
    IEnumerator DestroyObj(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
