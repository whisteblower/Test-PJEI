using UnityEngine;

public class LookAt : MonoBehaviour
{
    //LLAMAR A LA ESFERA 
    [SerializeField] Transform objetoTarget;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ACCI�N DE MIRAR HACIA UN PUNTO O COORDENADA 
        transform.LookAt(objetoTarget);
    }
}
