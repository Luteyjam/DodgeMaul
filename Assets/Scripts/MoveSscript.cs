using UnityEngine;
using System.Collections;

public class MoveSscript : MonoBehaviour {

    public new Rigidbody2D rigidbody;
    private float speed = 25;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        //Movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector2(-speed, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector2(speed, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector2(0,speed));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector2(0, -speed));
        }
    }
    
}
