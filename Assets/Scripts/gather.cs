using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class gather : MonoBehaviour
{
    public float _radius;
    public LayerMask _playerMask;
    public GameObject _menu, _upgradeMenu;
    player _player;
    Collider[] overlapRadius;
    public bool _leave, _showMeny;
    public GameObject _soundLib;
    private bool _audiPlay;

    public void Start()
    {
        _player = GameObject.Find("player").GetComponent<player>();
        _menu.SetActive(false);
        _soundLib = GameObject.Find("SoundLibrary");
    }

    public void Update()
    {
        PlaySound();
        _menu.SetActive(_showMeny);
        if( Vector3.Distance( _player.GetComponent<Transform>().position , _player.GetComponent<NavMeshAgent>().destination) < 1)
        {
            if (!_leave)
            {
                Radius();                
            }
            else
            {
                _player._inAction = false;               
                overlapRadius = Physics.OverlapSphere(transform.position, _radius, _playerMask);
                if (overlapRadius.Length == 0)
                {
                    _leave = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.Escape) && _showMeny)
            {
                quitmenu();
            }
        }  
    }

    public void PlaySound()
    {
        if(_audiPlay)
        {
            _soundLib.GetComponent<soundsLib>().audioPlay("MenuOpen");
            _audiPlay = !_audiPlay;
        }
    }

    public void quitmenu()
    {
        StartCoroutine(_wait());
    }

    IEnumerator _wait()
    {
        yield return new WaitForSeconds(.1f);
        if (GameObject.Find("scratch(Clone)") != null)
        {
            _wait();
            quitmenu();
        }
        else
        {
            _audiPlay = true;
            _leave = true;
            _showMeny = false;
        }
        
    }

    public void Radius()
    {       
        overlapRadius = Physics.OverlapSphere(transform.position, _radius, _playerMask);
        if (overlapRadius.Length > 0)
        {
            _player._inAction = true;
            _showMeny = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
