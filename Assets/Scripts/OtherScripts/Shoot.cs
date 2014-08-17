using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	/*
	public Rigidbody2D bullet;
	public float speed = 20f;
	private PlayerCharacter playerCharacter;
	public float fireRate = 0.5f;
	public float nextFire = 0.5f;
	// Use this for initialization
	void Start () {
	
		playerCharacter = GameObject.Find("Player").GetComponent<PlayerCharacter>();

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			if(playerCharacter.direction == 1)
			{
				// ... instantiate the rocket facing right and set it's velocity to the right. 
				Rigidbody2D bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0,0,90))) as Rigidbody2D;
				bulletInstance.velocity = new Vector2(speed, 0);
			}
			if(playerCharacter.direction == 2)
			{
				// ... instantiate the rocket facing right and set it's velocity to the right. 
				Rigidbody2D bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0,0,90))) as Rigidbody2D;
				bulletInstance.velocity = new Vector2(-speed, 0);
			}
		}
	}
}
*/
}