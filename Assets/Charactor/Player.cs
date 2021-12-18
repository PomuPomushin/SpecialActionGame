using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody rb;// Rigidbody�̋@�\���g�����߂̕ϐ�

    [SerializeField]// �ϐ��̒��O�ɓ��͂���ƁA�ϐ��̒l���G�f�B�^��ŕҏW�ł���
    private float jumpPower = 1500;//�W�����v��
    [SerializeField]
    private float moveSpeed = 300; //�ړ��X�s�[�h

    private Animator anim;//Animtor�̋@�\���g�����߂̕ϐ�

    private bool grounded;//�n�ʂɂ��Ă��邩�ǂ����𔻒肷�邽�߂̕ϐ�
    void Start()
    {
        rb = GetComponent<Rigidbody>();// rb��Rigidbody�̒l��������
        anim = GetComponent<Animator>();//anim��Animator�̒l��������
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))//����W�L�[�������ꂽ��A
        {
            transform.position += transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);//�O���Ɉړ��X�s�[�h*���Ԃ̌o�ߕ��i��
        }

        if (Input.GetKey(KeyCode.S))//����S�L�[�������ꂽ��A
        {
            transform.position += transform.TransformDirection(Vector3.back * moveSpeed * Time.deltaTime);//�O���Ɉړ��X�s�[�h*���Ԃ̌o�ߕ��i��
        }

        if (Input.GetKey(KeyCode.A))//����A�L�[�������ꂽ��A
        {
            transform.Rotate(new Vector3(0, -2, 0));//Roteta=��]����
        }

        if (Input.GetKey(KeyCode.D))//����D�L�[�������ꂽ��A
        {
            transform.Rotate(new Vector3(0, 2, 0));
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))//����W�܂���S�L�[�������ꂽ��A
        {
            anim.SetBool("isRunning", true);//�A�j���[�^�[��isRunning��true�ɂ���
        }
        else//�����łȂ����
        {
            anim.SetBool("isRunning", false);//�A�j���[�^�[��isRunning��false
        }


        if (Input.GetKeyDown(KeyCode.Space))//�����A�X�y�[�X�L�[�������ꂽ��
        {
            if (grounded == true)//�����n�ʂɂ��Ă�����A
            {
                rb.AddForce(Vector3.up * jumpPower);//Rigdbody�ɏ�����ɃW�����v�͂�������
            }
        }
    }
    private void OnCollisionEnter(Collision collision)//���̂ɐG�ꂽ���̏���
    {
        if (collision.gameObject.tag == "Ground")//�����A�G�ꂽ���̂̃^�O��Ground�Ȃ�A
        {
            grounded = true;//grounnded��true�ɂ���
        }
    }
    private void OnCollisionExit(Collision collision)//���̂ɗ��ꂽ���̏���
    {
        if (collision.gameObject.tag == "Ground")//�����A���ꂽ���̂̃^�O��Ground�Ȃ�A
        {
            grounded = false;//``grounnded��false�ɂ���private
        }
    }
} 
