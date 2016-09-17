using UnityEngine;
using System.Collections;

public class MoveSscript : MonoBehaviour {

    public new Rigidbody2D rigidbody;
    private float speed = 10;
    GameObject AttackSprite;
    public new Rigidbody2D rb;

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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15));
            Vector3 pos = transform.position;
            Vector3 shoot = worldPos - pos;
            Attack(shoot);
        }
    }

    public void Attack(Vector3 s)
    {
        GameObject attack = (GameObject)Instantiate(AttackSprite, transform.position, transform.rotation);
        rb = attack.GetComponent<Rigidbody2D>();
        rb.AddForce(s);
    }
    
}
