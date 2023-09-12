using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
  [SerializeField] TileObj tileObjPrefab;

  private void Start()
  {
    Generate();
  }

  void Generate()
  {
    Instantiate(tileObjPrefab);
  }
}
