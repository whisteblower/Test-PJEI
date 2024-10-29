using System.Collections;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject myObject;
    void Start()
    {
        //Invoca un método después de x segundos y que se lanza entre x segundos
        //(nombreMetodo, tiempo hasta lanzarse, tiempo entre lanzamientos)
        InvokeRepeating(nameof(SpawnObject), 2, 0.2f);
    }

    private void SpawnObject() 
    {
        Instantiate(myObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke(nameof(SpawnObject), 0);
            //InvokeRepeating(nameof(SpawnObject), 2, 0.2f);
        }
    }
}
