using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour
{
	/* 
	public float Coins = 0;
	public float speed = 1.0f;
	public string axisName = "Horizontal";
	private Animator anim;
	public string jumpButton = "Space";
	public float jumpPower = 10.0f;
	public float minJumpDelay = 0.5f;
	public Transform[] groundChecks;
	private float jumpTime = 0.0f;
	private Transform currentPlatform = null;
	private Vector3 currentPlatformDelta = Vector3.zero;
	public float direction = 1;
	//health
	public float Health = 100;
	public AudioClip jumpClip;
	public float Dead = 0;
	// Use this for initialization
	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Left and right movement
		anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis(axisName)));
		if(Input.GetAxis(axisName) < 0)
		{
			Vector3 newScale = transform.localScale;
			newScale.x = -1.0f;
			transform.localScale = newScale;
			direction = 2;
		}
		else if(Input.GetAxis(axisName) > 0)
		{
			Vector3 newScale = transform.localScale;
			newScale.x = 1.0f;
			transform.localScale = newScale;
			direction = 1;
		}
		transform.position += transform.right*Input.GetAxis(axisName)*speed*Time.deltaTime;
		//Jump Logic
		bool grounded = false;
		foreach(Transform groundCheck in groundChecks)
		{
			grounded |= Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
		}
		anim.SetBool("Grounded", grounded);
		if(jumpTime > 0)
		{
			jumpTime -= Time.deltaTime;
		}
		if(Input.GetButtonDown("Jump") && anim.GetBool("Grounded"))
		{
			anim.SetBool("Jump",true);
			rigidbody2D.AddForce(transform.up*jumpPower);
			jumpTime = minJumpDelay;
			AudioSource.PlayClipAtPoint(jumpClip, transform.position);
		}
		if(anim.GetBool("Grounded") && jumpTime <= 0)
		{
			anim.SetBool("Jump",false);
			
		}
		
		//Moving Platform Logic
		//Check platform
		foreach(Transform groundCheck in groundChecks)
		{
			RaycastHit2D hit = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
			if(currentPlatform != hit.transform)
			{
				currentPlatform = hit.transform;
				currentPlatformDelta = Vector3.zero;
			}
		}
		
		//Call death Function if health <= 0
		if(Health <= 0){
			Death();
		}
		
		
	}
	
	void Death () {
		//declare that the player is dead
		Debug.Log ("The player is dead!");
		Dead = 1;
		
	}
*/
}