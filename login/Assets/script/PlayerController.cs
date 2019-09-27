using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Rigidbody2D rigidbody;
	public int jumps;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
        	rigidbody.AddForce(Vector2.left * 10f);
        }

        if(Input.GetKey(KeyCode.D)){
        	rigidbody.AddForce(Vector2.right*10f);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
        	if(jumps > 0) {
        		jumps--;
        		rigidbody.AddForce(Vector2.up*5f, ForceMode2D.Impulse);
        	}
        }
    }
}
