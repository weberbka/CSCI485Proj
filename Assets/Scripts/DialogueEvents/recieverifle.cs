using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recieverifle : MonoBehaviour
{
	NPCInteraction script;
	bool eventActivated = false;
    // Start is called before the first frame update
    void Start()
    {
        script = this.GetComponent<NPCInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!eventActivated && script.dialoguePart == 2){
			script.player.GetComponent<Movement>().inventory = "Inventory: Rifle";
			eventActivated = true;
		}
    }
}
