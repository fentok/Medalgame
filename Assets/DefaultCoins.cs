using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCoins : MonoBehaviour {
    public GameObject coin;
    int initcoins = 100;
    int k = 0;

    // Use this for initialization
    void Start () {
        InitSpown();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void InitSpown()
    {
        while (k++ < initcoins)
        {
            Instantiate(coin, this.transform.position, this.transform.rotation);
        }
    }
}
