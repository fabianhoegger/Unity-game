
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyTerritory : MonoBehaviour
{

    public BoxCollider territory;
    public GameObject player;
    bool playerInTerritory;

    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    BasicEnemy basicenemy; 
    BasicEnemy basicenemy1; 
    BasicEnemy basicenemy2;

    private Animator ZombieAnimator;
    private Animator ZombieAnimator1;
    private Animator ZombieAnimator2;
    // Use this for initialization
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        basicenemy = enemy.GetComponent<BasicEnemy>();
        ZombieAnimator = enemy.GetComponent<Animator>();
        
        basicenemy1 = enemy1.GetComponent<BasicEnemy>();
        ZombieAnimator1 = enemy1.GetComponent<Animator>();
        
        basicenemy2 = enemy2.GetComponent<BasicEnemy>();
        ZombieAnimator2 = enemy2.GetComponent<Animator>();
        playerInTerritory = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (basicenemy ?? false)
        {
            if (playerInTerritory == true )
            {
                basicenemy.MoveToPlayer();
                ZombieAnimator.SetBool("PlayerInTer",true);
                
                basicenemy1.MoveToPlayer();
                ZombieAnimator1.SetBool("PlayerInTer", true);
                
                basicenemy2.MoveToPlayer();
                ZombieAnimator2.SetBool("PlayerInTer", true);
                //  Debug.Log("enemy_territory_says_move");


            }
            if (playerInTerritory == false)
            {
                ZombieAnimator.SetBool("PlayerInTer", false);
                ZombieAnimator1.SetBool("PlayerInTer", false);
                ZombieAnimator2.SetBool("PlayerInTer", false);
            }
        }
        

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered ontriggerenter1");

        if (other.gameObject == player)
        {
            playerInTerritory = true;
            Debug.Log("Entered ontriggerenter2");
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject == player)
        {
            playerInTerritory = false;
        }
    }
}