using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLvNight : MonoBehaviour
{
  public PlayerMovement movement;

  void OnCollisionEnter (Collision collisionInfo)
  {
    if (collisionInfo.collider.tag == "finishnight")
    {
      SceneManager.LoadScene(5);
    }
  }
}
