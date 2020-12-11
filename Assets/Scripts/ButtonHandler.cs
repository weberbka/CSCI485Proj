using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void startGame(){
		SceneManager.LoadScene("City1", LoadSceneMode.Single);
		Time.timeScale = 1.00f;
		PlayerData.food = 5f;
		PlayerData.weapons = 0f;
		PlayerData.medicine = 0f;
		PlayerData.wood = 0f;
		PlayerData.iron = 0f;
		PlayerData.weapon = new PlayerData.Weapon{name = "Fists", typeDice = 4, numDice = 1};
		PlayerData.lastWeapon = new PlayerData.Weapon{name = "Fists", typeDice = 4, numDice = 1};
		ResourceCollector.food = 0f;
		ResourceCollector.weapons = 0f;
		ResourceCollector.medicine = 0f;
		ResourceCollector.wood = 0f;
		ResourceCollector.iron = 0f;
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
