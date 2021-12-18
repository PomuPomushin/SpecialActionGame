using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    private Vector3 initialPosition;//床の初期位置

    [SerializeField]
    private int movex = 0;//x軸の動く幅

    [SerializeField]
    private int movey = 0;//y軸の動く幅

    [SerializeField]
    private int movez = 0;//z軸の動く幅

    [SerializeField]
    private int movespeed = 0;//動くスピード

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;// initialPositionに初期位置を代入する
    }

    // Update is called once per frame
    void Update()
    {
        //各座標をinitialposinion+move分動かす
        transform.position = new Vector3(Mathf.Sin(Time.time * movespeed) * movex + initialPosition.x, Mathf.Sin(Time.time * movespeed) * movey + initialPosition.y, Mathf.Sin(Time.time * movespeed) * movez + initialPosition.z);
    }
}

