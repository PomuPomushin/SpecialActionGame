using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[����؂�ւ���Ƃ��ɒǉ�����

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()//�Q�[���J�n���Ɉ�x�������s����鏈��
    {
        
    }

    // Update is called once per frame
    void Update()//�Q�[���J�n���ɉ�������s����鏈��
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)//�I�u�W�F�N�g�ɐG�ꂽ���̏���
    {
        if (collision.gameObject.tag == "Enemy")//����Enemy�̃^�O�����Ă�G�ɐG�ꂽ��
        {
            SceneManager.LoadScene("You are daed");//�Q�[���I�[�o�[�̃V�[���ɕς���
        }
    }
}

