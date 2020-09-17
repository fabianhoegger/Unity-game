using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float attack1Range = 1;
    public float timeBetweenAttacks;
    public static int Life = 15;
    public GameObject Zombie;
    private Animator thisAnim;
    private Rigidbody rigid;

    public static  bool near=false;//Metavliti gia elenxo oti eftase konta ston pexti
    bool dead = false;
    // Use this for initialization
    void Start()
    {
        thisAnim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void MoveToPlayer()
    {
        if (!dead)
        {
            if (Vector3.Distance(transform.position, target.position) <= 2 && !near)
            {
                near = true;
                thisAnim.SetBool("NearPlayer", true);
                // Debug.Log(" Enemy reached player");
                return;
            }
            else
            {
                //rotate to look at player
                transform.LookAt(target.position);
                transform.Rotate(new Vector3(0, -90, 0), Space.Self);
                //Debug.Log(" Enemy keeps moving");
                //move towards player
                if (Vector3.Distance(transform.position, target.position) > attack1Range)
                {
                    transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
                    near = false;
                    thisAnim.SetBool("NearPlayer", false);

                }
            }
        }
        
        
    }

    public void Rest()
    {

    }
    public void ReduceHealth(bool kick)
    {
         if(Life<=0)
        {

            thisAnim.SetTrigger("IsHit");
            dead = true;
        }
       else if(kick)
        {
            Life = Life - 4;
            Debug.Log("Minus 4");
        }
         else
        {
            Life = Life - 2;
            Debug.Log("Minus 2");

        }
       


    }
   


}
