using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
  [SerializeField] TileObj grassObjPrefab;
  [SerializeField] TileObj forestObjPrefab;
  [SerializeField] TileObj waterObjPrefab;
  [SerializeField] Transform tileParent;

  const int WIDTH = 15;
  const int HEIGHT = 9;
  const int WATER_RATE = 10;
  const int FOREST_RATE = 30;

  private void Start()
  {
    Generate();
  }

  void Generate()
  { 
    Vector2 offset = new Vector2(-WIDTH/2, -HEIGHT/2);
    for (int x = 0; x < WIDTH; x++)
    {
        for (int y = 0; y < HEIGHT; y++)
        {   
            Vector2 pos = new Vector2(x, y) + offset;
            int rate = Random.Range(0, 100); // 0 -99までの数字がランダムで1つでる
            if(rate < WATER_RATE)
            {
                Instantiate(waterObjPrefab, pos, Quaternion.identity, tileParent);
            }           
            else if(rate < FOREST_RATE)
            {
                Instantiate(forestObjPrefab, pos, Quaternion.identity, tileParent);
            }           
            else 
            {
                Instantiate(grassObjPrefab, pos, Quaternion.identity, tileParent);
            }           
        }
    }
  }
}
