using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OptionsWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = PlayerData.weapon.name + " " + PlayerData.weapon.numDice + "D" + PlayerData.weapon.typeDice;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
