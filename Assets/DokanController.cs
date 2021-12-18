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
        if (Input.GetKeyDown(KeyCode.DownArrow))//もし、下キーが押されたら
        {
            if (touched == true)//もしプレイヤーについていたら、
            {
                player.position = toDokan.position + new Vector3(0, 10, 0);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)//ものに触れた時の処理
    {
        if (collision.gameObject.tag == "Player")//もし触れたもののタグがプレイヤーなら
        {
            touched = true;
        }
    }
    private void OnCollisionExit(Collision collision)//ものに離れた時の処理
    {
        if (collision.gameObject.tag == "Player")//もし、離れたもののタグがプレイヤーなら
        {
            touched = false;//touchedをfalseにするprivate
        }
    }
   


}
