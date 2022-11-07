using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ninja : MonoBehaviour {

	private Rigidbody2D rb;
	private Animator anim;
	private float dirX, moveSpeed;
	private bool isHurting, isDead;
	private bool facingRight = true;
	private Vector3 localScale;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		localScale = transform.localScale;
		moveSpeed = 5f;


	}
	
	// Update is called once per frame
	void Update () {		
			dirX = Input.GetAxisRaw ("Horizontal") * moveSpeed;

		if (Input.GetButtonDown ("Jump") && rb.velocity.y == 0)
			rb.AddForce (Vector2.up * 700F);

		if (Mathf.Abs(dirX) > 0 && rb.velocity.y == 0 )
		 anim.SetBool ("isRunning", true);
		 else 		 
		 anim.SetBool ("isRunning", false);

		 if (rb.velocity.y == 0) {
			anim.SetBool ("isJumping", false);
			anim.SetBool ("isFalling", false);
		}

		 if (rb.velocity.y > 0)
			anim.SetBool ("isJumping", true);
		
		if (rb.velocity.y < 0) {
			anim.SetBool ("isJumping", false);
			anim.SetBool ("isFalling", true );
		}
				Attack();
	}

	void FixedUpdate()
	{
	rb.velocity = new Vector2 (dirX, rb.velocity.y);
	}


	void LateUpdate()
	{
		if (dirX > 0)
			facingRight = true;
		else if (dirX < 0)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;

	}
void Attack(){
		if ( Input.GetButtonDown("Fire1"))
		{
			anim.SetBool("isAttacking", true );
		}
		if ( Input.GetButtonUp("Fire1"))
		{
		anim.SetBool("isAttacking", false );
		}

}}


