using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;
    int currentindex = -1;
    int vehiculosRandom;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            vehiculosRandom = Random.Range(0, vehiculos.Length);
            vehiculos[vehiculosRandom].SetActive(true);


        }   
    }
    
    void ResetearVehiculos()
    {
        desactivartodoslosvehiculos();
        vehiculos[0].SetActive(true);
    }

    void desactivartodoslosvehiculos()
    {
        for (int i=0; i<vehiculos.Length;i++)
        {
            vehiculos[i].SetActive(false);
        }

    }
    
}
