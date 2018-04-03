using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerScript : MonoBehaviour {

    public GameObject scoreText;
    ScoreScript scoreS;

    AudioSource getSE;

    void Start()
    {
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

}
