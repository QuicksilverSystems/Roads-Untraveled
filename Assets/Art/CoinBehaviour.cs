using UnityEngine;
using System.Collections;

public class CoinBehaviour : MonoBehaviour {
	public AudioClip pickupClip;
	private Player player;
	public float GemValue = 0;

	void Awake() {
		player = GameObject.Find("Player").GetComponent<Player>();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		// If the player enters the trigger zone...
		if(other.tag == "Player")
		{
			// ... play the pickup sound effect.
			AudioSource.PlayClipAtPoint(pickupClip, transform.position);
			player.Gems += GemValue;
			Destroy(transform.root.gameObject);
		}

	}

}