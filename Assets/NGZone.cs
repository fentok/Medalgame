using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGZone: MonoBehaviour
{

    public GameObject JPText;
    public JPScript JPS;
    public float probabilityNG;     // NGゾーンに入ったときにJPが増える確率
    public float AddJP;             // NGゾーンに入ったときにJPが増える量


    void Start()
    {
        JPS = JPText.GetComponent<JPScript>();
    }

    void OnCollisionEnter(Collision colObject)
    {
        // Saucerと衝突したオブジェクトの「タグ」が"Coin"だったときに、
        // 衝突したオブジェクトを消す(Destroy)
        if (colObject.gameObject.tag == "Coin")
        {
            Destroy(colObject.gameObject);
            if (Random.value*100 < probabilityNG) {
                JPS.addJP(AddJP);
            }
        }
    }

}
