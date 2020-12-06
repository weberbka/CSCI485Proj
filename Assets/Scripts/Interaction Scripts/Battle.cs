using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Battle : MonoBehaviour
{
	int stateOfBattle = 0;
    // Start is called before the first frame update
    void Start()
    {
       this.gameObject.transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = PlayerData.weapon.name + " " + PlayerData.weapon.numDice + "D" + PlayerData.weapon.typeDice;
	   this.gameObject.transform.GetChild(1).gameObject.GetComponent<TMP_Text>().text = PlayerData.currentBattle.name + " " + PlayerData.currentBattle.numDice + "D" + PlayerData.currentBattle.typeDice;
	   Camera.main.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
		 if(Input.GetMouseButtonUp(0)){
			if(stateOfBattle == 0){
				RaycastHit2D hit = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0);
				if (hit && hit.collider.gameObject.name == "Dice"){
					float you = 0;
					for(int i = 0; i < PlayerData.weapon.numDice; i++){
						you += Random.Range(1.00f, (float) (PlayerData.weapon.typeDice + 0.9999));
					}
					float it = 0;
					for(int i = 0; i < PlayerData.currentBattle.numDice; i++){
						it += Random.Range(1.00f, (float) (PlayerData.currentBattle.typeDice + 0.9999));
					}
					this.gameObject.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().text = ((int)you).ToString() + " (You)  " + ((int)it).ToString() + " (It)";
					if(you >= it){
						//You won
						this.gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = true;
						stateOfBattle = 1;
					}else{
						//You lost
						this.gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
						stateOfBattle = 2;
					}
				}
			}else if(stateOfBattle == 1){
				//win
				
			}else if(stateOfBattle == 2){
				//lose
				SceneManager.LoadSceneAsync("EndScreen");
			}
		 }
    }
}
