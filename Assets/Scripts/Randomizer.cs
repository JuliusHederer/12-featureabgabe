using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour

    private int rand;
public Sprite[] Sprite_pic;


void Start()
{
    Change();
}


void Update()
{
    if (Input.GetMouseButtonDown(0))
        }  

void Change()
        {
            rand = Random.Range(0, Sprite_Pic.Length);
            GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
        {
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
