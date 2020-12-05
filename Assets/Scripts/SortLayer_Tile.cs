using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortLayer_Tile : MonoBehaviour
{
	private Renderer sprite;
	public float divisorFromTop;
	
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sprite) sprite.sortingOrder = (int) ((this.transform.position.y + sprite.bounds.size.y/divisorFromTop)* -10);
    }
}
