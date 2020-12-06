using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void startGame(){
		SceneManager.LoadScene("City1", LoadSceneMode.Single);
		Time.timeScale = 1.00f;
	}
	public void openOptions(){
		SceneManager.LoadScene("OptionsMenu", LoadSceneMode.Single);
		Time.timeScale = 1.00f;
	}
	public void openMainMenu(){
		SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
		Time.timeScale = 1.00f;
	}
	public void exitApplication(){
		Application.Quit();
	}
}
