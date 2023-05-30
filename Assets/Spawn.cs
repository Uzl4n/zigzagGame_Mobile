using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float currentTime = 0;
    
    public GameObject spawnPoint;
    public GameObject pista;
    public static float targetTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= 4.0f)
        {

        GameObject lastPista = Instantiate(pista,this.spawnPoint.transform.position,Quaternion.Euler(0,0,0));
        spawnPoint = lastPista.transform.Find("pontoSpawn").gameObject;
        currentTime = 0;
        
        }
    }
}
