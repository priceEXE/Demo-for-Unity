using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clotty : MonoBehaviour
{
    public float speed = 1;
    private enum Direction{up,down,left,right};
    private Direction direction;
    private float attack_frequency = 2f;
    public Rigidbody2D _rigidBody;
    private float invoketime = 0f;
    public GameObject bullet_pre;

    public float attack_length = 1f;

    private float bullet_speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        invoketime+=Time.deltaTime;
        if(invoketime > attack_frequency )
        {
            invoketime = 0f;
            direction = (Direction)UnityEngine.Random.Range(0,4);
        //    GameObject bullet_up =  Instantiate(bullet_pre,transform.position,Quaternion.identity);
        //    GameObject bullet_down = Instantiate(bullet_pre,transform.position,Quaternion.identity);
            GameObject bullet_left = Instantiate(bullet_pre,transform.position,Quaternion.identity);
            GameObject bullet_right = Instantiate(bullet_pre,transform.position,Quaternion.identity);
        //    bullet_up.GetComponent<EnamyBullet>().SetSpeed(new Vector2(0,bullet_speed));
        //    bullet_down.GetComponent<EnamyBullet>().SetSpeed(new Vector2(0,-bullet_speed));
            bullet_left.GetComponent<EnamyBullet>().SetSpeed(new Vector2(-bullet_speed,0));
            bullet_right.GetComponent<EnamyBullet>().SetSpeed(new Vector2(bullet_speed,0));
            switch (direction)
            {
                case Direction.up:
                    _rigidBody.AddForce(new Vector2(0,speed),ForceMode2D.Impulse);
                    break;
                case Direction.down:
                    _rigidBody.AddForce(new Vector2(0,-speed),ForceMode2D.Impulse);
                    break;
                case Direction.left:
                    _rigidBody.AddForce(new Vector2(-speed,0),ForceMode2D.Impulse);
                    break;
                case Direction.right:
                    _rigidBody.AddForce(new Vector2(speed,0),ForceMode2D.Impulse);
                    break;

            }
        }
    }
}
