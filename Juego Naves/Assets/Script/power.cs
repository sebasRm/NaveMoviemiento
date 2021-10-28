﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{

    public float velocidadUp;
    void Start()
    {
        velocidadUp = 2.0f;
    }

    void Update()
    {
        transform.Translate(Vector3.down * velocidadUp * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("estoy colisionando con - " + other.name);
        if (other.tag == "Player")
        {
            movimiento player = other.GetComponent<movimiento>();
            if (player != null)
            {
                player.Poweer();

            }
        }
        Destroy(this.gameObject);
    }

}