﻿using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {
	
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	public float smoothFollow = 0f;
	
	// Update is called once per frame
	void Start() {
		if (smoothFollow == 1) {
			dampTime = 0.15f;
		}

		else if(smoothFollow == 0) {
			dampTime = 0f;
		}
	}

	void Update () 
	{
		if (target)
		{
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
		
	}
}