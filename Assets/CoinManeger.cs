using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;//�ǉ����܂��傤

public class CoinManeger : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject coin_object = null;


    void Start()
    {
        
    }

    // Update is called once per frame
    // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
    void Update()
    {
        Text coin_text = coin_object.GetComponent<Text>();
        coin_text.text = Player.point.ToString();
    }
}
