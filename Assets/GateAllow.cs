using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateAllow: MonoBehaviour
{
    public float time_Fadeout;

    SpriteRenderer spRanderer;
    public GameObject scoreText;
    ScoreScript scoreS;

    AudioSource getSE;

    // Use this for initialization
    void Start()
    {
        spRanderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float alpha = Mathf.Cos(Time.time/time_Fadeout)/2.0f+0.6f;
        var color = spRanderer.color;
        color.a = alpha;
        spRanderer.color = color;
    }
}
