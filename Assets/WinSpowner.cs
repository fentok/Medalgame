using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinSpowner : MonoBehaviour {

    public float waitTimes = 0.2F;

    Vector3 initPosition;
    Vector3 newPosition;
    public GameObject coin;

    public float speed;
    public float randspeed;
    public int payout;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    void Payout()
    {
        GameObject coins = GameObject.Instantiate(coin) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.forward * speed;
        coin.GetComponent<Rigidbody>().AddForce(force);
    }

    public void Payout(int m)
    {
        while (m-- > 0)
        {
            Payout();
            yield return new WaitForSeconds(waitTimes);
        }
    }
}
