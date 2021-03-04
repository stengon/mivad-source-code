using UnityEngine;

public class PlayerColision : MonoBehaviour
{
		public PlayerMovement movement;
		public AudioSource Engine;

	void Start()
	{
			Engine = GetComponent<AudioSource>();
	}

	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
			Engine.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
