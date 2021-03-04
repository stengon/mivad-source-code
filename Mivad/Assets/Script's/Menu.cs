using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public void ButtonStart ()
	{
		SceneManager.LoadScene(3);
	}

	public void ButtonCredits ()
	{
		SceneManager.LoadScene(2);
	}

	public void ButtonOptions ()
	{
		SceneManager.LoadScene(1);
	}

	public void ButtonExit ()
	{
		Application.Quit();
	}
}
