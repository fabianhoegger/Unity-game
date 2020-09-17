using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zpunch : MonoBehaviour
{
    public CapsuleCollider area;
    public GameObject Player;
    Move playerlife;
    void Start()
    {
        playerlife = Player.GetComponent<Move>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (other.gameObject == Player)
        {
            Debug.Log("hit");
            playerlife.ReduceHealth();
        }
    }
   

}

