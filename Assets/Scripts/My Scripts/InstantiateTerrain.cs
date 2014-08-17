using UnityEngine;
using System.Collections;

public class InstantiateTerrain : MonoBehaviour {


	//The backdrop
	public Transform backGround;
	//the meteor spawner
	public Transform meteorSpawner;
	//the 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		// If the player enters the trigger zone...
		if(other.tag == "Player")
		{

			Instantiate(meteorSpawner, transform.position, transform.rotation);
			Instantiate(backGround, transform.position, transform.rotation);
		}
	}
}
