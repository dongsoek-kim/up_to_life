using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Control : MonoBehaviour
{
    
    int speed = 10; //스피드 
    int jump_speed = 330;
    bool left_button = false;
    bool right_button = false;
    bool now_jump = false;
    Animator animator;
    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
        
    }

    void Update()
    { 
        
        if(Gamemanager.instance.level>0) animator.SetInteger("job", Gamemanager.instance.ch_job);
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x축으로 이동할 양 
        if (xMove > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetInteger("move", 1);
            this.transform.Translate(new Vector3(xMove, 0, 0));  //이동
        }
        else if (xMove < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetInteger("move", 1);
            this.transform.Translate(new Vector3(xMove, 0, 0));  //이동
        }
        if (left_button)
        {
            xMove = -1 * speed * Time.deltaTime; //x축으로 이동할 양 
            this.transform.Translate(new Vector3(xMove, 0, 0));  //이동
        }
        if (right_button)
        {
            xMove = 1 * speed * Time.deltaTime; //x축으로 이동할 양 
            this.transform.Translate(new Vector3(xMove, 0, 0));  //이동
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (now_jump != true)
            {
                Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
                rigidbody2D.AddForce(Vector3.up * jump_speed);
                now_jump = true;
                animator.SetInteger("jump", 1);
            }
        }
        if (xMove == 0) animator.SetInteger("move", 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "floor")
        {
            now_jump = false;
            animator.SetInteger("jump", 0);
        }
    }
    public void Left_move()
    {
        left_button = true;
        transform.localScale = new Vector3(1, 1, 1);
        animator.SetInteger("move",1);
    }
    public void Right_move()
    {
        right_button = true;
        transform.localScale = new Vector3(-1, 1, 1);
        animator.SetInteger("move", 1);
    }
    public void Jump()
    {
        if (now_jump != true)
        {
            animator.SetInteger("jump", 1);
            Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
            rigidbody2D.AddForce(Vector3.up * jump_speed);
            now_jump = true;
        }
    }
    public void OnPointerUp()
    {
        left_button = false;
        right_button = false;
        animator.SetInteger("move", 0);
    }
}


