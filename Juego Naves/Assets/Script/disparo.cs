using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    [SerializeField]
    private float velocidadDisparo = 20.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * velocidadDisparo * Time.deltaTime);

        if(transform.position.y >= 1.6f)
        {
            Destroy(this.gameObject);
        }
        
    }
}
