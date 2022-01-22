using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//NavMeshAgentを使用するときに追記する

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;//追跡するターゲット
　　NavMeshAgent agent;//NavMeshAgentを使用するための変数
    // use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;//agetの目的地をtargetoの座標にする
    }
}
