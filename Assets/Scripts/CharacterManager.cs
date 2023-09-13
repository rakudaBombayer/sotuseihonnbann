using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{   
    //キャラ全てを管理する
    // Start is called before the first frame update
    public List<Character> characters = new List<Character>();

    void Start()
    {
        // データ方が一致する小要素を全て取得する
        GetComponentsInChildren(characters);
    }
}
