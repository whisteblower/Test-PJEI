using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float giro;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ROTO EL OBJETO Y UTILIZO LA VARIABLE DE GIRO 
        transform.Rotate(Vector3.forward * Time.deltaTime * giro);

    }
}
