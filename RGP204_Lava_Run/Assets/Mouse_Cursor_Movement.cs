using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Cursor_Movement : MonoBehaviour {

    public Vector3 mousePosition;
    public Rigidbody2D rb;
    private Vector2 direction;
    public float moveSpeed = 50f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButton(0))
        //{
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector3(direction.x * moveSpeed, direction.y * moveSpeed);
        //}
        //else {
            //rb.velocity = Vector2.zero;
        //}
    }
}
