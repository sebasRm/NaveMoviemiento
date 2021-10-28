using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public string estadoNave = "mi estado";

    public float velocidadNave;
    public float velocidadNaveLados = 3.0f;

    public float movimientoHorizontal;
    public float movimientoVertical;

    public int vidasNave = 3;

    private bool powerUpvelocidad = false;

    // public GameObject disparoUno;

    void Start()
    {
        // transform.position = new Vector3(0.614f, -0.463f, -2.35f);
        //  Debug.Log(estadoNave);
        velocidadNave = 10.0f;
    }


    // Update is called once per frame
    void Update()
    {
        //moviemintoNave();
        // disparo();

        float Horizontal = Input.GetAxis("Horizontal") * velocidadNave * Time.deltaTime;
        print(Horizontal);
        transform.Translate(Horizontal, 0, 0);
        aumentarVelocidad();


    }


   /* void moviemintoNave()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * velocidadNaveLados * movimientoHorizontal);

        movimientoVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * velocidadNave * movimientoVertical);

        if (transform.position.x <= -1.6)
        {
            transform.position = new Vector3(-1.6f, transform.position.y, -1.6f);
        }
        else if (transform.position.x >= 2.86)
        {
            transform.position = new Vector3(2.86f, transform.position.y, -1.6f);
        }

        else if (transform.position.y >= 1.49)
        {
            transform.position = new Vector3(transform.position.x, 1.49f, -1.6f);
        }
        else if (transform.position.y <= -0.5)
        {
            transform.position = new Vector3(transform.position.x, -0.5f, -1.6f);
        }
    }*/

    void aumentarVelocidad()
    {

        float horizontal = Input.GetAxis("Horizontal");

        if (powerUpvelocidad == true)
        {

            transform.Translate(Vector3.right * velocidadNave * 5.0f * horizontal * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * velocidadNave * horizontal * Time.deltaTime);


        }

    }

    public void Poweer()
    {
        powerUpvelocidad = true;
        StartCoroutine(powerDown());
    }

    IEnumerator powerDown()
    {
        yield return new WaitForSeconds(5.0f);
        powerUpvelocidad = false;
    }

    /* void disparo()
     {
         if (Input.GetKey(KeyCode.Space))
         {
             Instantiate(disparoUno, transform.position + new Vector3(0, 0.5f, -1.16f), Quaternion.identity);
         }
         else if(Input.GetKey(KeyCode.T))
         {
             Instantiate(disparoUno, transform.position + new Vector3(0, 0.5f, -1.16f), Quaternion.identity);
             Instantiate(disparoUno, transform.position + new Vector3(0.2f, 0.1f, -1.16f), Quaternion.identity);
             Instantiate(disparoUno, transform.position + new Vector3(-0.2f, 0.1f, -1.16f), Quaternion.identity);
         }
     }*/

}
