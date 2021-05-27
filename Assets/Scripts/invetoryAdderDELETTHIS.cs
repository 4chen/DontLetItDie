using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invetoryAdderDELETTHIS : MonoBehaviour
{
    public GameObject _inventory;
    public GameObject _slot;
    public List<GameObject> _inven = new List<GameObject>();

    public void Start()
    {
        _inventory = GameObject.Find("Inventory");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GameObject _sloted;
            _sloted = Instantiate(_slot,Vector2.zero,Quaternion.identity,_inventory.transform);
            _inven.Add(_sloted);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if(_inven.Count > 0)
            {
                _inven.RemoveAt(0);
            }
        }
    }
}
