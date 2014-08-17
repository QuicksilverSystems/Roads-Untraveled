using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public Collider fireButtonObject;
	public bool fireButtonDown = false;
	public bool fireButton = false;



	#region InputManager stuff
	//THERE CAN ONLY BE ONE.... InputManager
	private static InputManager instance = null;


	public static InputManager Instance {

		get {return instance; }

	}

	// Use this for initialization
	void Awake () {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		}
		else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
		gameObject.name = "Controls";
	}
	#endregion



	// Update is called once per frame
	void Update () {
	
		fireButton = false;


		if(Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android)
		{

		
			foreach(Touch touch in Input.touches)
			{

				RaycastHit hit;

				if(Physics.Raycast(Camera.main.ScreenPointToRay(touch.position), out hit, Mathf.Infinity))
				{
					if(touch.phase == TouchPhase.Began) {

						if(hit.collider == fireButtonObject) {
							fireButtonDown = true;
						}

						else {
							hit.collider.gameObject.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
						}
					
					}

					if(hit.collider == fireButtonObject) {
						fireButton = true;
					}

					else {
						hit.collider.gameObject.SendMessage("OnTouchOver", hit.point, SendMessageOptions.DontRequireReceiver);
					}
				}
			}
			foreach(Touch touch in Input.touches)
			{
				
				RaycastHit hit;
				
				if(Physics.Raycast(Camera.main.ScreenPointToRay(touch.position), out hit, Mathf.Infinity))
				{
					if(hit.collider == fireButtonObject) {
						fireButton = true;
					}
					else {
						hit.collider.gameObject.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
					}
					
				}
			}
		}

		else 
		{

			RaycastHit hit;
			
			if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity)) {
			if (Input.GetMouseButton(0)) {

					if(hit.collider == fireButtonObject) {
						fireButton = true;
					}
					else {
					hit.collider.gameObject.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
					}

				}
		}

	}
}
}