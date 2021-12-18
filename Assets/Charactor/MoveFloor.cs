using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    private Vector3 initialPosition;//���̏����ʒu

    [SerializeField]
    private int movex = 0;//x���̓�����

    [SerializeField]
    private int movey = 0;//y���̓�����

    [SerializeField]
    private int movez = 0;//z���̓�����

    [SerializeField]
    private int movespeed = 0;//�����X�s�[�h

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;// initialPosition�ɏ����ʒu��������
    }

    // Update is called once per frame
    void Update()
    {
        //�e���W��initialposinion+move��������
        transform.position = new Vector3(Mathf.Sin(Time.time * movespeed) * movex + initialPosition.x, Mathf.Sin(Time.time * movespeed) * movey + initialPosition.y, Mathf.Sin(Time.time * movespeed) * movez + initialPosition.z);
    }
}

