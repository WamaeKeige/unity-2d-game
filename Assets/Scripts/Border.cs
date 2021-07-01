using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    void Start()
    {
     player =  GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void onTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "border"){
            Destroy(this.gameObject);
        }
        else if(collision.tag == "player") {
            Destroy(player.gameObject);
        }
    }
}
