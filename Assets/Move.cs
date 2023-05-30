using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    private float speed = 0.05f;
    private float direction = 1;
    public int pontos = 0;
    public Text pontosUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == 1){
            transform.position += new Vector3(0,0,speed);
        }

        else if(direction == 2){
            transform.position += new Vector3(speed,0,0);
        }

        

        if(Input.GetKeyUp(KeyCode.Space) || Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Began)
        {
            direction++;
            if(direction > 2){
                 direction = 1;
            }
        }

        if(transform.position.y < -1f){

            Application.LoadLevel(Application.loadedLevel);
            pontos = 0;
        }
    }
    

    void OnCollisionEnter(Collision col)
    {
        delete del         = col.collider.gameObject.transform.parent.GetComponent<delete>();
        del.touched        = true;
        pontos++;
        pontosUI.text      = pontos.ToString();
        speed             += 0.006f;
        Spawn.targetTime  -= 0.3f;

        if(Spawn.targetTime < 0.5f){
            Spawn.targetTime = 0.5f;
        }
    }
}
