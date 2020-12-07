using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionTextPro : MonoBehaviour
{
	public static string text = "";
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<TMP_Text>().text = text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
