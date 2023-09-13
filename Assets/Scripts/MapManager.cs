using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] Cursor cursor;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast(
                clickPosition,
                Vector2.down
            ); 
            if (hit2D && hit2D.collider)
            {
                cursor.SetPosition(hit2D.transform);
                TileObj tileObj = hit2D.transform.GetComponent<TileObj>();
                Debug.Log(tileObj.positionInt);
            }
        }
    }
}
