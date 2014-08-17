using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {

	public float fireRate = 0.1f;
	public float nextFire = 0.1f;
	public Transform Explosion;
	public float Damage = 40f;
	public float meteorHealth = 100;

	//Find the instance of "Player"
	void Awake() {

	}

	void Update () {
		if (meteorHealth <= 0) {
			MeteorDestoy();
			Debug.Log("Meteor Destroyed!");
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		// If the player enters the trigger zone...
		if(other.tag == "Player" && Time.time > nextFire)
		{
			other.gameObject.GetComponent<Player>().playerHealth -= Damage;
			nextFire = Time.time + fireRate;
			Debug.Log("Meteor Hit!");
			meteorHealth -= 100;
		}

		if(other.tag == "Shield" && Time.time > nextFire)
		{
			other.gameObject.GetComponent<Shield>().shieldHealth -= Damage;
			nextFire = Time.time + fireRate;
			Debug.Log("Meteor Hit!");
			meteorHealth -= 100;
		}
	}

	void MeteorDestoy() {
		Instantiate(Explosion, transform.position, transform.rotation);
		Destroy (gameObject, 0.01f);
		Debug.Log("Meteor Destroyed!");
	}

}
