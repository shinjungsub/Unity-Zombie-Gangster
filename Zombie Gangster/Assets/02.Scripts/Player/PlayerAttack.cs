using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public float speed = 3f;
    private bool attack = false;
    int eating = 0;

    Vector3 rotation = Vector3.zero;
    Animator animator;

	// Use this for initialization
	void Start () {
        rotation = transform.eulerAngles;
        animator = GetComponent<Animator>();
        eating = Animator.StringToHash("Base Layer.Zombie_Eating");

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Zombie_Eating"))
        {
            Debug.Log("이팅상태");
        }

    }

    private void OnCollisionEnter(Collision coll)
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Zombie_Eating"))
        {
            if (coll.gameObject.tag == "Enemy")
            {
                Destroy(coll.gameObject);
            }
        }
    }

    public void Attack()
    {
        animator.Play("Zombie_Eating");
    }
}
