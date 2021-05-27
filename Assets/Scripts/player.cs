using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class player : MonoBehaviour
{
    NavMeshAgent _NMA;
    public LayerMask _groundLayer;
    public bool _inAction;
    private GameObject _soundLib;
    private bool _step;

    
    public void Start()
    {
        _NMA = GetComponent<NavMeshAgent>();
        _soundLib = GameObject.Find("SoundLibrary");
    }

    public void Update()
    {
        if(!_inAction)
        {
            canMove();
        }
    }

    public void canMove()
    {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray,out hit))
            {
                if(hit.collider.gameObject.layer == LayerMask.NameToLayer("ground"))
                {
                    moveToTarget(hit.point);
                    
                    
                }
            }
        }

        if(Vector3.Distance(transform.position,_NMA.destination) > 1)
        {
            if(!_step)
            StartCoroutine(walkSound());
        }
    }

    IEnumerator walkSound()
    {
        _step = !_step;
        _soundLib.GetComponent<soundsLib>().audioPlay("Walk");
        yield return  new WaitForSeconds(.25f);
        _step = !_step;
    }

    public void moveToTarget(Vector3 Target)
    {
        _NMA.SetDestination(Target);
    }

}
