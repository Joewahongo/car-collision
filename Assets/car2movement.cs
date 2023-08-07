using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car2movement : MonoBehaviour
{
    // variable
    public float speed;
    public bool onGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("car"))
        {
            onGround = false;
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
