using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//NavMeshAgent���g�p����Ƃ��ɒǋL����

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;//�ǐՂ���^�[�Q�b�g
�@�@NavMeshAgent agent;//NavMeshAgent���g�p���邽�߂̕ϐ�
    // use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;//aget�̖ړI�n��targeto�̍��W�ɂ���
    }
}
