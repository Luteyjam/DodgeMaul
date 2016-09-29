using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {

    public new Rigidbody2D rigidbody;
    public new GameObject o;
    public float count;
    bool isColliding;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        o = this.gameObject;
        count = 0;
        Physics2D.IgnoreCollision(o.GetComponent<Collider2D>(), GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>(), true);
        isColliding = true;
    }
	
	// Update is called once per frame
	void Update () {
        isColliding = false;
	if(count >= 3)
        {
            Destroy(o);
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (isColliding)
        {
            return;
        }
        isColliding = true;
        if(coll.gameObject.tag == "Barrier")
        {
            count += 1;
        }
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(coll.gameObject);
        }
    }
}
