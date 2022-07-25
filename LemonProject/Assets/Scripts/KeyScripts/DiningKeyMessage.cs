using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiningKeyMessage : MonoBehaviour
{
    public GameObject keyFound1;
    void Start()
    {
        keyFound1.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            //StartCoroutine(WaitForSec());
            keyFound1.SetActive(true);
            Destroy(keyFound1, 5f);
            //Invoke("DisableDiningMessage", 5f);
        }
    }
    /* Testing destroy functions
    void DisableDiningMessage()
    {
        Debug.Log("Destorying dining key!");
        Destroy(keyFound1);
    }
    */
    /*
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1f);
        Destroy(keyFound1);
        //Destroy(gameObject);
    }
    */
}
