using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Vector2Int positionInt;

    public Vector2Int Position { get => positionInt; }
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = (Vector2)positionInt;   
    }

    // キャラを移動
    public void Move(Vector2Int pos) 
    {
        positionInt = pos;
        transform.position = (Vector2)positionInt;
    }
}

//選択タイルの取得
//キャラの選択
//選択タイルの座標とキャラの座標を比較する。
//全てのキャラを管理するクラスを作る
//キャラの移動

