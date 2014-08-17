using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	//setup for distance travvelled:
	public float distanceTravelled = 0;
	Vector3 lastPosition;
	
	public float playerHealth = 100;
	public float ConstantSpeed = 5f;
	private Animator anim;
	public float Gems = 0f;
	public float forwardSpeed = 3.0f;
	public float horizontalSpeed = 5.0f;
	public float playerCapacitor = 100f;

	private string axisName = "Horizontal";
	private string axisName2 = "Vertical";
	public float bankDirection = 0f;
	public float Acceleration = 0f;

	public Transform SpeedLines;
	public float SpeedLinesExist = 0;
	public Transform SpeedLinesInstance;

	public Transform BackwardsSpeedLines;
	public float BackwardsSpeedLinesExist = 0;
	public Transform BackwardsSpeedLinesInstance;



	
	// public GameObject SpeedLinesObject;

	
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		//initial position
		lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {


		//update distance:
		distanceTravelled += Vector3.Distance(transform.position, lastPosition);
		lastPosition = transform.position;

		//check if the player is dead
		if ( playerHealth <= 0) {
			Death();
		}


		//Constant forward motion
		transform.Translate(0, ConstantSpeed * Time.deltaTime, 0);

		// SpeedLinesObject = GameObject.Find ("SpeedLines");
		transform.position += transform.right*Input.GetAxis(axisName)*horizontalSpeed*Time.deltaTime;
		transform.position += transform.up*Input.GetAxis(axisName2)*forwardSpeed*Time.deltaTime;

		if (Input.GetAxis(axisName) < 0 && playerCapacitor > 0) {
			anim.SetFloat("BankDirection", 1);
			bankDirection = 1f;
		}

		else if(Input.GetAxis(axisName) > 0 && playerCapacitor > 0) {
			bankDirection = -1f;
			anim.SetFloat("BankDirection", -1);
		}

		else if(Input.GetAxis(axisName) == 0 && playerCapacitor > 0) {
			bankDirection = 0f;
			anim.SetFloat("BankDirection", 0);
		}

		if (Input.GetAxis(axisName2) < 0) {
			anim.SetFloat("Acceleration", -1);
			Acceleration = -1f;
		}
		
		else if(Input.GetAxis(axisName2) > 0) {
			Acceleration = 1f;
			anim.SetFloat("Acceleration", 1);
		}
		
		else if(Input.GetAxis(axisName2) == 0) {
			Acceleration = 0f;
			anim.SetFloat("Acceleration", 0);
		}

		if (Acceleration == 1 && SpeedLinesExist == 0 && playerCapacitor > 0) {
			SpeedLinesExist = 1;
			BackwardsSpeedLinesExist = 0;
			SpeedLinesInstance = Instantiate(SpeedLines, transform.position, transform.rotation) as Transform;
			SpeedLinesInstance.transform.parent = GameObject.Find ("Player").transform;
			Destroy(GameObject.Find ("BackWardsSpeedLines(Clone)"));
		}

		if (Acceleration == -1 && BackwardsSpeedLinesExist == 0 && playerCapacitor > 0) {
			SpeedLinesExist = 0;
			BackwardsSpeedLinesExist = 1;
			BackwardsSpeedLinesInstance = Instantiate(BackwardsSpeedLines, transform.position, transform.rotation) as Transform;
			BackwardsSpeedLinesInstance.transform.parent = GameObject.Find ("Player").transform;
			Destroy(GameObject.Find ("Speedlines(Clone)"));
		}

		if (Acceleration == 0) {
			SpeedLinesExist = 0;
			BackwardsSpeedLinesExist = 0;
			Destroy(GameObject.Find ("Speedlines(Clone)"));
			Destroy(GameObject.Find ("BackWardsSpeedLines(Clone)"));
		}
		
	}

	void Death () {
		anim.SetBool("IsDead?", true);
		Gems = 0;
		forwardSpeed = 0.0f;
		horizontalSpeed = 0.0f;
		ConstantSpeed = 0f;
		playerCapacitor = 0f;
	}
}
