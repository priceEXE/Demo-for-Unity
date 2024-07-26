using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamyBullet : MonoBehaviour
{
    public Clotty clotty;
    private Rigidbody2D Rigidbody;

    private void Awake() {
        Rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSpeed(Vector2 direction)
    {
        Rigidbody.velocity = direction;
    //    StartCoroutine(DestroyObj(clotty.attack_length));
    }

    /*IEnumerator DestroyObj(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }*/

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Wall") || other.gameObject.CompareTag("Player") || other.CompareTag("Obstract"))
        {
            Destroy(gameObject);
        }
    }
}
