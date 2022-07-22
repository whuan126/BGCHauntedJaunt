using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public Transform player;
    bool m_IsPlayerTouching;
    public GameEnding gameEnding;

    void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            //Debug.Log("Player is touching");
            m_IsPlayerTouching = true;
        }
    }
    void OnTriggerExit(Collider collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            //Debug.Log("Player is NOT touching");
            m_IsPlayerTouching = false;
        }
    }

    void Update()
    {
        if(m_IsPlayerTouching)
        {
            //Debug.Log("John Lemon is caught!");
            gameEnding.CaughtPlayer();
        }
    }

}
