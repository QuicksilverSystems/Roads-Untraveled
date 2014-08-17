using UnityEngine;
using System.Collections;

public class ConstantRotation : MonoBehaviour {

	public float xRotation;
	public float yRotation;
	public float zRotation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (xRotation*Time.deltaTime,yRotation*Time.deltaTime, (Random.Range(0, 90))*Time.deltaTime); //rotates randomly around the z axis
	}
}
