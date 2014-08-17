using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	public GameObject Meteor;
	public GameObject laserHit;
	public float damage = 50f;
	public float destroyTime =2f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		//destroy after a se time
		Destroy(gameObject, destroyTime);

	}
	void OnTriggerEnter2D (Collider2D other)
	{
		// If the enemy enters the bullet...
		if(other.gameObject.tag == "Meteor")
		{
			Instantiate(laserHit, transform.position, transform.rotation);
			other.gameObject.GetComponent<Meteor>().meteorHealth -= damage;
			Debug.Log("damage");
			Destroy(gameObject);
			/*Meteor = col.gameObject;
			Meteor = col.gameObject.GetComponent<Meteor>();
			Meteor.meteorHealth -= Damage;
			Destroy(transform.root.gameObject);*/
		}
		
	}

	void Hit (){

	}
}
