using UnityEngine;
using System.Collections;

public class Weapon_Laser : MonoBehaviour {

	private Player player;
	public Rigidbody2D Laser;
	public float bulletSpeed = 20;
	public float fireRate = 0.5f;
	public float nextFire = 0.5f;
	public AudioClip laserClip;
	public float weaponCapactiorCost = 1;
	//private bool fired = false;


	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {

		//bool fired = false;


		if((Input.GetButtonDown("Fire1") || InputManager.Instance.fireButton) && Time.time > nextFire  && player.playerCapacitor > 0) {
			AudioSource.PlayClipAtPoint(laserClip, transform.position);
			nextFire = Time.time + fireRate;
			// ... instantiate the laser facing right and set it's velocity to the right. 
			Rigidbody2D bulletInstance = Instantiate(Laser, transform.position, transform.rotation) as Rigidbody2D;
			bulletInstance.velocity = new Vector2(0, bulletSpeed);
			//sbutract from the capactior
			player.playerCapacitor -= weaponCapactiorCost;
		}
	}

}
