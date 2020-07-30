using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rb2d;  //for physics
    public float force = 20f;
    public bool isEnemy = true;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.up * force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && isEnemy)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if(collision.tag =="Enemy" && !isEnemy)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
