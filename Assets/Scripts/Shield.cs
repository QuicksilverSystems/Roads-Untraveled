using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	public float shieldHealth = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (shieldHealth <= 0) {
			Destroy(gameObject);
			Debug.Log("Shield Destroyed!");
		}
	}
}