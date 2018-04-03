using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class JPScript : MonoBehaviour
{
    /*
     * JPの初期値を
     * インスペクタ上から設定できるようにpublic 変数で宣言しておく
     */
    public float initJP;
    public float timeOut;
    private float timeElapsed;
    float currentJP;
    Text JPText;

    void Start()
    {
        currentJP = initJP;
        JPText = this.GetComponent<Text>();
        printJP(initJP);
    }
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            addJP(0.01f);
            timeElapsed = 0.0f;
        }
    }
    // スコアを減点する関数
    public void subJP(float n)
    {
        currentJP -= n;
        printJP(currentJP);
    }

    // スコアを加点する関数
    public void addJP(float n)
    {
        currentJP += n;
        printJP(currentJP);
    }

    void printJP(float n)
    {
        /*
         * JPTextのTextに整数を代入する。
         * JPText.textはstring型(文字列)を受け取るが、nはint型(整数)なので、
         * nをstring型に変換してあげる必要がある。
         */
        JPText.text = "JP : " + n.ToString("F2");
    }
}