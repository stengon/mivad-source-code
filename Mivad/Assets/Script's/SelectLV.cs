using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLV : MonoBehaviour
{
	public void BackButton ()
	{
		SceneManager.LoadScene(0);
	}

	public void BackButtonNightDay ()
	{
		SceneManager.LoadScene(3);
	}

	public void LevelOneButton ()
	{
		SceneManager.LoadScene(6);
	}

	public void LevelTwoButton ()
	{
		SceneManager.LoadScene(7);
	}

	public void LevelThreeButton ()
	{
		SceneManager.LoadScene(8);
	}

	public void LevelFourButton ()
	{
		SceneManager.LoadScene(9);
	}

	public void LevelFiveButton ()
	{
		SceneManager.LoadScene(10);
	}

	public void LevelSixButton ()
	{
		SceneManager.LoadScene(11);
	}

	public void LevelOneButtonNight ()
	{
		SceneManager.LoadScene(12);
	}

	public void LevelTwoButtonNight ()
	{
		SceneManager.LoadScene(13);
	}

	public void LevelThreeButtonNight ()
	{
		SceneManager.LoadScene(14);
	}

	public void LevelFourButtonNight ()
	{
		SceneManager.LoadScene(15);
	}

	public void LevelFiveButtonNight ()
	{
		SceneManager.LoadScene(16);
	}

	public void LevelSixButtonNight ()
	{
		SceneManager.LoadScene(17);
	}

	public void Day ()
	{
		SceneManager.LoadScene(4);
	}

	public void Night ()
	{
		SceneManager.LoadScene(5);
	}
}
