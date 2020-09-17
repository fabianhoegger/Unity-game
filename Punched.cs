using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punched : MonoBehaviour
{
    public SphereCollider area;


   // public GameObject enemy;//give enemy here
    //BasicEnemy basicenemy;//class instance
    BasicEnemy check;//class instance
    public bool kick =false;

    // Start is called before the first frame update
    void Start()
    {

       // basicenemy = enemy.GetComponent<BasicEnemy>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider other)
    {
        check = other.GetComponent<BasicEnemy>();
        

        if (check ?? false)//check that the collision was with a zombie
        {
            
            if (Input.GetKey("g"))
            {
                Debug.Log("kicked zombie");
                 check.ReduceHealth(kick);

            }
            if (Input.GetKey("f") )
            {
                Debug.Log("hit zombie");
                check.ReduceHealth(kick);

            }
        }
    }

}
