using UnityEngine;
using System.Collections;

public class Spowner : MonoBehaviour
{

    float moveSpeed = 2.0f;
    Rigidbody rb;
    public GameObject coin;
    public GameObject leftWall;
    public GameObject rightWall;
    float leftWallPositionZ;
    float rightWallPositionZ;
    public GameObject scoreText;
    ScoreScript scoreS;
    AudioSource getSE;

    void Start()
    {
        // スクリプトを付けたゲームオブジェクトのRigidbodyコンポーネントを取得する
        rb = this.GetComponent<Rigidbody>();
        leftWallPositionZ = (leftWall.transform.position.z)+1;
        rightWallPositionZ = (rightWall.transform.position.z)-1;

        getSE = this.GetComponent<AudioSource>();

        scoreS = scoreText.GetComponent<ScoreScript>();
    }
    void Update()
    {
        Vector3 currentPosition = this.transform.position;
        currentPosition.z = Mathf.Clamp(currentPosition.z, leftWallPositionZ, rightWallPositionZ);
        this.transform.position = currentPosition;
        /*
         * Inputクラスは入力システムに関する関数が含まれている。
         * GetAxisでPCの矢印キーの入力を受け付けることができる。
         * "Horizontal"だと、左右の矢印キーの入力を受け付け、"Vertical"だと
            上下の矢印キーの入力を受け付けるようになる。
         * http://docs.unity3d.com/ja/current/ScriptReference/Input.GetAxis.html
         */
        float z = Input.GetAxis("Horizontal");

        // キー入力された際の移動する向きを決める。
        // 今回はx軸方向に移動させたい
        Vector3 direction = new Vector3(0, 0, z);

        // velocity(速度)に代入することによって、このオブジェクトの移動速度が決定される
        rb.velocity = direction * moveSpeed;

        /* スペースキーが押されたときにcoinを生成する。
         * 第一引数は生成するオブジェクト、第二引数は生成する場所、
           第三引数は生成する角度
         */
        if (Input.GetKeyDown("space"))
        {
            Instantiate(coin, this.transform.position, this.transform.rotation);
            scoreS.subScore(1);
            getSE.PlayOneShot(getSE.clip);
        }

        
    }
}