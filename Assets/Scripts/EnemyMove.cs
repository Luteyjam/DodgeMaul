using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

    public new Rigidbody2D rigidbody;
    private float speed = 10;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        int i = Random.Range(1, 4);
        if( i == 1)
        {
            rigidbody.AddForce(new Vector2(0, speed));
        }
        if (i == 2)
        {
            rigidbody.AddForce(new Vector2(speed, 0));
        }
        if (i == 3)
        {
            rigidbody.AddForce(new Vector2(0, -speed));
        }
        if (i == 4)
        {
            rigidbody.AddForce(new Vector2(-speed, 0));
        }
    }
}
