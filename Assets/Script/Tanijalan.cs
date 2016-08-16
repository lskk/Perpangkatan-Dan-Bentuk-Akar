using UnityEngine;
using System.Collections;

public class Tanijalan : MonoBehaviour {

    public int moveSpeed;
    public int jumpHeight;
    Rigidbody2D rb2D;
	void Start () {
        rb2D = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
        Vector2 moveDir = new Vector2(Input.GetAxisRaw("Horizontal")*moveSpeed,rb2D.velocity.y);
       // Vector2 moveDir2 = new Vector2(Input.GetAxisRaw("Vertical") * moveSpeed, rb2D.velocity.x);
        rb2D.velocity = moveDir;

	}
}
