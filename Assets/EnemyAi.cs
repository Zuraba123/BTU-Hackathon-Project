using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyAi : MonoBehaviour
{
    public int enhp;
    public GameObject enemy;
    public GameObject sword;
    public Transform player;
    public Transform ally;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    { 
        if (enhp <= 0)
        {
            Destroy(enemy);
        }
        if (Vector3.Distance(player.position, this.transform.position) < 50)
        {
            Vector3 direction = player.position - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                        Quaternion.LookRotation(direction), 0.15f);
            animator.SetBool("idle", false);
            if (direction.magnitude > 1)
            {
                this.transform.Translate(0, 0, 0.15f);
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

        if (Vector3.Distance(ally.position, this.transform.position) < 50)
        {
            Vector3 direction = ally.position - this.transform.position;
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
    void OnColliderEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.gameObject == sword)
            enhp = enhp - 50;
    }
}
