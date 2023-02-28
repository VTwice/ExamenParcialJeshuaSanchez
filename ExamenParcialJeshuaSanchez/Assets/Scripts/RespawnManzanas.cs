using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManzanas : MonoBehaviour
{
    //Ejes movimineto manzanas
    [SerializeField] private float minX;

    [SerializeField] private float maxX;

    // Z

    [SerializeField] private float minZ;

    [SerializeField] private float maxZ;

    //Daño oncollider

    public GameObject prefab;

    //Tiempo de respawn de las manzanas

    public float respawnManzanas;

    private float timetor;

    void Start()
    {
        timetor = respawnManzanas;
    }


    void Update()
    {
        timetor += Time.deltaTime;
        if (timetor >= respawnManzanas)
        {
            timetor = 0f;

            float objetoRandomX = Random.Range(minX, maxX);
            float objetoRandomZ = Random.Range(minZ, maxZ);


            GameObject prefapObjeto = Instantiate(prefab, new Vector3(objetoRandomX, 80, objetoRandomZ), Quaternion.identity);
            Debug.Log("Objeto");
        }

    }


}


