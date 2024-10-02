using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Outline>().OutlineWidth = 2;
        Destroy(gameObject);
    }
}
