using UnityEngine;
using System.Collections;

public class SpawnMeteors : MonoBehaviour {

	public GameObject meteor;
	public float SpawnAmount;
	public float TotalSpawnAmount;


	public float lowerXRange = 0f;
	public float upperXRange = 0f;


	public float lowerYRange = 0f;
	public float upperYRange = 0f;

	// Use this for initialization
	void Start () {
		for (SpawnAmount=0; SpawnAmount<TotalSpawnAmount; SpawnAmount++)
			spawnMeteors();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void spawnMeteors () {
		Vector2 position = new Vector2(Random.Range(lowerXRange, upperXRange), Random.Range(lowerYRange, upperYRange));
		Instantiate(meteor, position, Quaternion.identity);
	}
}
