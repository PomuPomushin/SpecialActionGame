using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンを切り替えるときに追加する

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()//ゲーム開始時に一度だけ実行される処理
    {
        
    }

    // Update is called once per frame
    void Update()//ゲーム開始時に何回も実行される処理
    {
        
    }

    private void OnCollisionEnter(Collision collision)//オブジェクトに触れた時の処理
    {
        if (collision.gameObject.tag == "Enemy")//もしEnemyのタグがついてる敵に触れたら
        {
            SceneManager.LoadScene("YouAreDead");//ゲームオーバーのシーンに変える
        }
    }
}

