using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour
{
    public GameObject MoveWall1;
    public GameObject MoveWall2;

    void OnTriggerEnter(Collider keyCollect)
    {
        if (keyCollect.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(MoveWall1);
            Destroy(MoveWall2);
        }
    }
}
