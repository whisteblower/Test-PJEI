using UnityEngine;

public class Impulse : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float jumpforce;
    private Rigidbody rb;
    void Start()
    {
        //COJO EL RIGIDBODY
        rb = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        //APLICAR UNA FUERZA
        //rb.AddForce(Vector3.up * force);

        //MOVER EL CUBO SEGUN LAS FLECHAS UTILIZANDO FUERZA
        float forceX = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * force * forceX);

        //HACER SALTAR EL CUBO CON LA BARRA ESPACIADORA
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce);
        }
        else 
        {
            /*rb.mass = 0;
            rb.AddForce(Vector3.down * jumpforce);
            rb.velocity.x = 0;
            rb.velocity.y = 0;
            rb.velocity.z = 0;*/
        }

        //APLICAR TORSION

        //rb.AddTorque(torsionX, 0, 0);

        //ULTILIZAMOS LAS FLECHAS IZQUIERDA Y DERECHA PARA TORSIONARLO
        float torsionX = Input.GetAxis("Horizontal");
        rb.AddTorque(Vector3.right * force * torsionX);


    }
}
