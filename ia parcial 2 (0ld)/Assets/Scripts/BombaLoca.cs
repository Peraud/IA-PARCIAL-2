using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaLoca : Enemy
{
    private Animator anim;
    public AudioSource explosion;

    [SerializeField] private float distanciaParaCorrer = 5;
    [SerializeField] private float distanciaParaExplotar = 1;
    [SerializeField] private float runSpeed = 3;

    LineOfSight _lineofSight;
    public bool inSight;
    public bool inSmallSight;

    private bool _exploto = false;


    void Awake()
    {
        anim = GetComponent<Animator>();
        _lineofSight = GetComponent<LineOfSight>();
    }

    void Update()
    {
        

        if (_lineofSight.IsInSight(Player.transform) && !_exploto)
        {
            Vector3 lookAtPos = Player.transform.position;
            transform.LookAt(lookAtPos);
            correrHaciaPlayer();
            anim.SetBool("walk", true);
            
        }
        else
        {
            anim.SetBool("walk", false);
        }

        
        //distanceToPlayer = Vector3.Distance(transform.position, Player.transform.position);

        //if (distanceToPlayer <= distanciaParaCorrer && !_exploto)
        //{
        //    correrHaciaPlayer();
        //    anim.SetBool("walk", true);
        //}
        //else
        //{
        //    anim.SetBool("walk", false);
        //}

        //if(distanceToPlayer <= distanciaParaExplotar && !_exploto)
        //{
        //    anim.SetBool("walk", false);
        //    _exploto = true;
        //    anim.SetTrigger("attack01");

        //    StartCoroutine(hacerDañoEnSegundos(1.5f));
        //}

    }
    void correrHaciaPlayer()
    {
        transform.position += transform.forward * runSpeed * Time.deltaTime;
    }
    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            anim.SetBool("walk", false);
            _exploto = true;
            anim.SetTrigger("attack01");
            // GetComponent<BoxCollider>().enabled = false
            GetComponent<BombaLoca>().enabled = false;

            Destroy(this.gameObject, 1.5f);
        }
    }
}
