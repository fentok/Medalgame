using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {

    Vector3 initPosition;
    public Vector3 newPosition;
    public float Size;
    public float time;

    public GameObject scoreText;
    ScoreScript scoreS;

    AudioSource getSE;

    // Use this for initialization
    void Start()
    {
        
        initPosition = this.transform.position;
        
        scoreS = scoreText.GetComponent<ScoreScript>();
        getSE = this.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision colObject)
    {

        // Saucerと衝突したオブジェクトの「タグ」が"Coin"だったときに、
        // 衝突したオブジェクトを消す(Destroy)
        if (colObject.gameObject.tag == "Coin")
        {
            Destroy(colObject.gameObject);
            scoreS.addScore(2);
            getSE.PlayOneShot(getSE.clip);
        }
    }
    public void FixedUpdate()
    {
        newPosition = new Vector3(initPosition.x + Size * Mathf.Sin((Time.time) / time), initPosition.y , initPosition.z);
        this.GetComponent<Rigidbody>().MovePosition(newPosition);
    }
}
