using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed;
	public float lompat;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	// Use this for initialization
	void Start () {

	}
	void FixedUpdate(){
		grounded = Physics.CheckSphere (groundCheck.position, groundCheckRadius, whatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && grounded){
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, lompat);
			audio.Play();
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			rigidbody.velocity = new Vector3(speed,rigidbody.velocity.y);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			rigidbody.velocity = new Vector3(-speed,rigidbody.velocity.y);
		}
	}
}
