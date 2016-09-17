using UnityEngine;
using System.Collections;

public class MoveSscript : MonoBehaviour {

    protected new Rigidbody2D rigidbody;
    private float speed = 25;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponentInParent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        //Movement
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector2(-speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector2(speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector2(0,speed));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector2(0, -speed));
        }
    }
    
}
