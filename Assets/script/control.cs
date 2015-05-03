using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public float moveSpeed;
	public float jumpHeight;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	void FixedUpdate(){

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && grounded)
	    {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, jumpHeight);
			audio.Play();

		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			rigidbody2D.velocity = new Vector2 (-moveSpeed,rigidbody2D.velocity.y);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			rigidbody2D.velocity = new Vector2 (moveSpeed,rigidbody2D.velocity.y);
		}
		anim.SetFloat ("right", rigidbody2D.velocity.x);
		anim.SetFloat("left",-rigidbody2D.velocity.x);
	
	}
}
