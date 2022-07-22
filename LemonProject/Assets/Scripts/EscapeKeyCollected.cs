using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeKeyCollected : MonoBehaviour
{
    public GameObject ExitWall1;
    public GameObject ExitWall2;
    public GameObject ExitWall3;
    public GameObject ExitWall4;

    void OnTriggerEnter(Collider keyCollect)
    {
        if (keyCollect.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(ExitWall1);
            Destroy(ExitWall2);
            Destroy(ExitWall3);
            Destroy(ExitWall4);
        }
    }
}
