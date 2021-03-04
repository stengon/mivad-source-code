using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLvDay : MonoBehaviour
{
  public PlayerMovement movement;

  void OnCollisionEnter (Collision collisionInfo)
  {
    if (collisionInfo.collider.tag == "finish")
    {
      SceneManager.LoadScene(4);
    }
  }
}
