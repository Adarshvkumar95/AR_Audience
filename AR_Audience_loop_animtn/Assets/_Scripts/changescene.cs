using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class changescene : MonoBehaviour
{
	public Animator animator;
	private int levelToLoad;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			FadeToNextLevel();
		}
	}

	public void FadeToNextLevel()
	{
		FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void FadeToLevel(int levelIndex)
	{
		levelToLoad = levelIndex;
		animator.SetTrigger("Fade_Out");
	}

	public void OnFadeComplete()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}


