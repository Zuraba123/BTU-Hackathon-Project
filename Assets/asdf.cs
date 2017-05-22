using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class asdf : MonoBehaviour
{
    public Transform enemy;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Vector3.Distance(enemy.position, this.transform.position) < 50)
        {
            Vector3 direction = enemy.position - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                        Quaternion.LookRotation(direction), 0.1f);
            animator.SetBool("idle", false);
            if (direction.magnitude > 1)
            {
                this.transform.Translate(0, 0, 0.2f);
                animator.SetBool("run", true);
            }
            if (direction.magnitude < 1)
            {
                animator.SetBool("attack", true);
                animator.SetBool("run", false);
            }
        }
        else
        {
            animator.SetBool("idle", true);
            animator.SetBool("run", false);
            animator.SetBool("attack", false);
        }
    }
}