using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5.0f;
    public Joystick joystick;
    public Animator animator;



    void start()
    {
        animator = this.gameObject.GetComponent<Animator>();

    }

    void Update()
    {

        //joy stickの動き
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);
 

            //Vector.zero : (0,0,0)なので、動いたら….

            if (moveVector != Vector3.zero)
            {

                animator.SetBool("Walking", true);

                //transformのrotationに入れる。
                transform.rotation = Quaternion.LookRotation(moveVector);

                //移動…movespeedは移動速度のパラメータ。
                transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);

            }



            else
            {

            //動いていない場合は走らない。
            animator.SetBool("Walking", false);

            }

    }

    public void Attack() {
        animator.SetBool("Attack", true);
        Invoke("False", 1);
     
    }

    public void False()
    {
        animator.SetBool("Attack", false);

    }
}
