using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DokanController : MonoBehaviour
{
    public Transform toDokan;
    public Transform player;

    private bool touched;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))//�����A���L�[�������ꂽ��
        {
            if (touched == true)//�����v���C���[�ɂ��Ă�����A
            {
                player.position = toDokan.position + new Vector3(0, 10, 0);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)//���̂ɐG�ꂽ���̏���
    {
        if (collision.gameObject.tag == "Player")//�����G�ꂽ���̂̃^�O���v���C���[�Ȃ�
        {
            touched = true;
        }
    }
    private void OnCollisionExit(Collision collision)//���̂ɗ��ꂽ���̏���
    {
        if (collision.gameObject.tag == "Player")//�����A���ꂽ���̂̃^�O���v���C���[�Ȃ�
        {
            touched = false;//touched��false�ɂ���private
        }
    }
   


}
