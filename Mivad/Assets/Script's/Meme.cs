using UnityEngine;

public class Meme : MonoBehaviour
{
    void Update()
    {
      if ( Input.GetKey("m") )
      {
          transform.Rotate(new Vector3(0f, 0f, 50f));
      }
    }
}
