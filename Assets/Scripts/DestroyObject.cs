using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private bool _enterTrigger = false;
    private void OnTriggerEnter(Collider other)
    {
        _enterTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _enterTrigger = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E)&&(_enterTrigger))
        {
            Destroy(gameObject);
        }
    }
}
