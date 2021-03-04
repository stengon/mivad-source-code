using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwadForce = 1000f;
	public float sidewaysForce = 700f;

    void FixedUpdate()
    {
			rb.AddForce(0, 0, forwadForce * Time.deltaTime);

			if ( Input.GetKey("d") )
			{
				rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
			}

			if ( Input.GetKey("a") )
			{
				rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
			}

      if (rb.position.y < -2f)
      {
        FindObjectOfType<GameManager>().EndGame();
      }
    }
}
