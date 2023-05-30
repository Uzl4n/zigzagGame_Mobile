using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");

        if(Vector3.Distance(transform.position, player.transform.position) >= 60f && touched == true){

            Destroy(this.gameObject);
        }
    }
}
