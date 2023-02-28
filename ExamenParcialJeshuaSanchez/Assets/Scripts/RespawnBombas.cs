using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RespawnBombas : MonoBehaviour
{
    [SerializeField] private float minX;

    [SerializeField] private float maxX;

    // Z

    [SerializeField] private float minZ;

    [SerializeField] private float maxZ;

    //Daño

    public GameObject prefab;

    //Tiempo respawn de las  bombas

    public float respawnBombas;

    private float timetor;

    void Start()
    {
        timetor = respawnBombas;
    }

    
    void Update()
    {
        timetor += Time.deltaTime;
        if (timetor >= respawnBombas)
        {
            timetor = 0f;
            
            float objetoRandomX = Random.Range(minX, maxX);
            float objetoRandomZ = Random.Range(minZ, maxZ);

            
            GameObject prefapObjeto = Instantiate(prefab, new Vector3(objetoRandomX, 80, objetoRandomZ), Quaternion.identity);
            Debug.Log("Objeto");
        }

    }


}
