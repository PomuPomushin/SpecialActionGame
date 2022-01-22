using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;//追加しましょう

public class CoinManeger : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject coin_object = null;


    void Start()
    {
        
    }

    // Update is called once per frame
    // オブジェクトからTextコンポーネントを取得
    void Update()
    {
        Text coin_text = coin_object.GetComponent<Text>();
        coin_text.text = Player.point.ToString();
    }
}
