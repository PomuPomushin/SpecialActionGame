using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody rb;// Rigidbodyの機能を使うための変数

    [SerializeField]// 変数の直前に入力すると、変数の値をエディタ上で編集できる
    private float jumpPower = 1500;//ジャンプ力
    [SerializeField]
    private float moveSpeed = 300; //移動スピード

    private Animator anim;//Animtorの機能を使うための変数

    private bool grounded;//地面についているかどうかを判定するための変数
    void Start()
    {
        rb = GetComponent<Rigidbody>();// rbにRigidbodyの値を代入する
        anim = GetComponent<Animator>();//animにAnimatorの値を代入する
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))//もしWキーが押されたら、
        {
            transform.position += transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);//前方に移動スピード*時間の経過分進む
        }

        if (Input.GetKey(KeyCode.S))//もしSキーが押されたら、
        {
            transform.position += transform.TransformDirection(Vector3.back * moveSpeed * Time.deltaTime);//前方に移動スピード*時間の経過分進む
        }

        if (Input.GetKey(KeyCode.A))//もしAキーが押されたら、
        {
            transform.Rotate(new Vector3(0, -2, 0));//Roteta=回転する
        }

        if (Input.GetKey(KeyCode.D))//もしDキーが押されたら、
        {
            transform.Rotate(new Vector3(0, 2, 0));
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))//もしWまたはSキーがおされたら、
        {
            anim.SetBool("isRunning", true);//アニメーターのisRunningをtrueにする
        }
        else//そうでなければ
        {
            anim.SetBool("isRunning", false);//アニメーターのisRunningをfalse
        }


        if (Input.GetKeyDown(KeyCode.Space))//もし、スペースキーが押されたら
        {
            if (grounded == true)//もし地面についていたら、
            {
                rb.AddForce(Vector3.up * jumpPower);//Rigdbodyに上向きにジャンプ力をかける
            }
        }
    }
    private void OnCollisionEnter(Collision collision)//ものに触れた時の処理
    {
        if (collision.gameObject.tag == "Ground")//もし、触れたもののタグがGroundなら、
        {
            grounded = true;//grounndedをtrueにする
        }
    }
    private void OnCollisionExit(Collision collision)//ものに離れた時の処理
    {
        if (collision.gameObject.tag == "Ground")//もし、離れたもののタグがGroundなら、
        {
            grounded = false;//``grounndedをfalseにするprivate
        }
    }
} 
