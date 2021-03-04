using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

  bool gameHasEnden = false;

  public float restartDelay = 1f;

  public void EndGame ()
  {
    if (gameHasEnden == false)
    {
      gameHasEnden = true;
      Invoke("Restart", restartDelay);
    }
  }

    void Restart ()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
