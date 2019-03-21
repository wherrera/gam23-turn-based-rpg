using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour {

    public GameObject dialog;

    void OnTriggerEnter2D(Collider2D col)
    {
        dialog.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        dialog.SetActive(false);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
