using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enamy : MonoBehaviour
{
    public Bullet bullet;
    public Rigidbody2D _rigidBody;
    public GameObject roomArea;
    private int health = 5;
    public float attack_length;

    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {

        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //命中和击退效果
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Bullet") && health>0)   
        {
            health--;
            _rigidBody.AddForce(new Vector2(transform.position.x-other.transform.position.x,transform.position.y-other.transform.position.y),ForceMode2D.Impulse);
        }
        else if(other.gameObject.CompareTag("Bullet") && health==0)
        {
            Destroy(gameObject);
            roomArea.GetComponent<RoomArea>().Count_enamy--;
        }
    }

    
    
}
