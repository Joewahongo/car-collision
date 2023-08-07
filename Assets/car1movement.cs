using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car1movement : MonoBehaviour
{
    // variables
    private float move;
    public float speed;
    public Rigidbody2D rb;
    public bool onGround = true;

    [SerializeField] private AudioSource collisionSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(speed * move, rb.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("car"))
        {
            onGround = false;

            collisionSound.Play();
            Debug.Log("collided");
            speed *= -1;
            transform.Rotate(Vector3.forward, 180f);
        }

        if (other.gameObject.CompareTag("car"))
        {
            Debug.Log("after");
        }
    }
}
