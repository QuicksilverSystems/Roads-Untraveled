using UnityEngine;
using System.Collections;

public class OnTouchDownDebug : MonoBehaviour {

	// Use this for initialization
	void OnTouchOver(Vector3 mousePosition) {

		Debug.Log ("We got touched at:" + mousePosition);

	}
}
