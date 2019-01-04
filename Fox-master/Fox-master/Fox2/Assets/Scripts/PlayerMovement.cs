using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Rigidbody2D myRB;

	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	public bool onLadder;
	public bool ladderTop;
	public float climbSpeed;
	bool crouch = false;
	
	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{

			if(onLadder)
			{
				//move up
				animator.SetBool("isClimbing", true);
				IsClimbing();
				//transform.Translate(Vector3.up *climbSpeed* Time.deltaTime);
				if(!ladderTop)
				{
					myRB.AddForce (Vector3.up* climbSpeed);
					//myRB.velocity=  Vector2.up*climbSpeed;
				}
			}	
			else{
			jump = true;
			animator.SetBool("isJumping", true);
			}
		}

		if (Input.GetButtonDown("Crouch"))
		{
			if(onLadder)
			{
				//move down
				animator.SetBool("isClimbing", true);
				IsClimbing();
				//transform.Translate(Vector3.down*climbSpeed* Time.deltaTime);
				myRB.AddForce (Vector3.down* climbSpeed);
				
			}
			else{
			crouch = true;
			}
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

	}


public void NotClimbing()
{
	onLadder = false;
	animator.SetBool("isClimbing", false);
	myRB.gravityScale = 3;
}

public void IsClimbing()
{
	jump = false;
	animator.SetBool("isJumping", false);
	myRB.gravityScale = 0;
	myRB.velocity = new Vector2(0, 0);
}
public void OnLanding()
{
	animator.SetBool("isJumping", false);
}
public void OnCrouching(bool iscrouching)
{
	animator.SetBool("isCrouching", iscrouching);
}
	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
