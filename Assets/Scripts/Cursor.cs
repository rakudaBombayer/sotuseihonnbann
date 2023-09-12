using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    //TODO クリックしたオブジェクトにカーソルを移動させたい
    
    

    // ・カーソルを移動させたい
    public void SetPosition(Transform target)
    {
        transform.position = target.position;
    }

    // ・クリックしたオブジェクトを場所を取得したい
    // クリック判定 =>Update関数の中でInput系を使う
    //クリックしたオブジェクトを場所を取得したい => クリックしg田場所にRayを飛ばしてオブジェクトを取得する

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("左クリックしたよ");
        }
    }

}
