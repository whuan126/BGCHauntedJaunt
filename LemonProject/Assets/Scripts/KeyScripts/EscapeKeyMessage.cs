using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeKeyMessage : MonoBehaviour
{
    public GameObject keyFound2;
    void Start()
    {
        keyFound2.SetActive(false);
    }
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            keyFound2.SetActive(true);
            Destroy(keyFound2, 5f);
        }
    }
}
