using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAgent : MonoBehaviour
{

    public AudioClip[] ouch;
    public AudioClip[] dead;


    private AudioSource _audioSource;

    public float maxHp = 30.0f;

    public float currhp;
    public SphereCollider fist;

    public BoxCollider boxcollider;
    public Transform trans;

    Transform tr;
    Animator anim;
    Rigidbody rg;
    bool walking;
    bool backing;

    int timer = 0;

    bool attack = false;
    bool attack2 = false;

    private float h = 0.0f;
    private float v = 0.0f;
    private float r = 0.0f;
    private float s = 0.0f;

    public bool isGameover = false;


    public GameObject Fist;
    public Transform FistPos;

    public Quaternion rot;
    public float movespeed = 10.0f;
    public float rotspeed = 100.0f;

    // Use this for initialization
    void Start()
    {

        currhp = maxHp;
        _audioSource = GetComponent<AudioSource>();
        tr = GetComponent<Transform>();
        rg = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        fist.enabled = false;

        if (Input.GetMouseButtonDown(1) && !isGameover)
        {
            anim.SetTrigger("Attack");
            walking = false;
            attack2 = true;

        }
        if (Input.GetMouseButtonDown(0) && !isGameover)
        {

            attack = true;

            //anim.SetTrigger("Attack2");
            walking = false;


        }
        else
        {
            attack = false;
        }
        if (attack2)
        {
            timer++;

            if (timer == 1)
            {
                fist.enabled = true;
                Instantiate(Fist, FistPos.position, FistPos.rotation);
            }

        }

        if (attack)
        {
            timer++;

            if (timer == 1)
            {
                fist.enabled = true;
                anim.SetTrigger("Attack2");
                Instantiate(Fist, FistPos.position, FistPos.rotation);
            }

        }
        if (timer > 3)
        {
            attack = false;
            attack2 = false;
            timer = 0;
        }


    }

    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");





        Vector3 movement = transform.forward * v * movespeed * Time.deltaTime;



        if (v > 0)
        {
            rg.MovePosition(rg.position + movement);
        }
        else
        {
            rg.MovePosition(rg.position + (9 * movement) / 10);
        }


        float turn = h * rotspeed * Time.deltaTime;
        rot = Quaternion.Euler(0f, turn, 0f);
        rg.MoveRotation(rg.rotation * rot);

        Animating();

    }

    void Animating()
    {
        walking = v > 0;// || h != 0f;
        backing = v < 0f;
        anim.SetBool("IsWalk", walking);
        anim.SetBool("IsBack", backing);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PALM" && this.currhp > 0.0f)
        {
            //Destroy(other.gameObject);
            this.currhp -= 3.4f;
            _audioSource.PlayOneShot(ouch[0], 1.0f);

            if (this.currhp <= 0.0)
            {
                _audioSource.PlayOneShot(dead[0], 1.0f);
                anim.SetTrigger("DIE");
                this.isGameover = true;
                this.GetComponent<CapsuleCollider>().enabled = false;
                this.GetComponent<SphereCollider>().enabled = false;
            }


        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Enemy2") && this.currhp > 0.0f)
        {
            
            this.currhp -= 3.4f;
            _audioSource.PlayOneShot(ouch[0], 1.0f);

            if (this.currhp <= 0.0)
            {
                _audioSource.PlayOneShot(dead[0], 1.0f);
                anim.SetTrigger("DIE");
                this.isGameover = true;
            }


        }





    }
}
