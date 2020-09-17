using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Life=4;
    private Animator thisAnim;
    private Rigidbody rigid;
    public float groundDistance = 0.3f;
    public float JumpForce = 500;
    public LayerMask whatIsGround;
    float h;
    float v;
    bool jump = false;
    public GameObject player;
    void Start()
    {
        thisAnim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        
    }
    

    // Update is called once per frame
    void Update()
    {
         h = Input.GetAxis("Horizontal");
         v = Input.GetAxis("Vertical");
       
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            thisAnim.SetTrigger("Jump");
        }
       
        if (Input.GetKey("f"))
        {
            thisAnim.SetTrigger("Punch");
        }
        if (Input.GetKey("g"))
        {
            thisAnim.SetTrigger("Kick");
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            thisAnim.SetTrigger("Slide");
        }
       


    }
    void FixedUpdate()
    {
        thisAnim.SetFloat("Speed", v);
        thisAnim.SetFloat("TurningSpeed", h);
        if (jump)
        {
            rigid.AddForce(Vector3.up * JumpForce);
            rigid.AddForce(Vector3.forward * 100);
            jump = false;
        }
        if (Physics.Raycast(transform.position + (Vector3.up * 0.1f), Vector3.down, groundDistance, whatIsGround))
        {
            thisAnim.SetBool("IsGrounded", true);
            thisAnim.applyRootMotion = true;
        }
        else
        {
            thisAnim.SetBool("IsGrounded", false);
        }
    }
     public void ReduceHealth()
    {
        Life = Life - 2;
        Debug.Log("Lost");
        if(Life<0)
        {
            Destroy(player);
        }
    }
}
