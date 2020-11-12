using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortLayer : MonoBehaviour
{
	private SpriteRenderer sprite;
	
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sprite) sprite.sortingOrder = (int) ((this.transform.position.y + sprite.bounds.size.y)* -10);
    }
}
