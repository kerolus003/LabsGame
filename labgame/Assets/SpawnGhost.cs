using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{  
    public Transform enemy;
    public Transform SpawnGhost;
    // Start is called before the first frame update

    void RespawnEnemy(){
      Instantiate(enemy,SpawnGhost.Transform.position,SpawnGhost.Transform.rotation);
    }
    void OnTriggerEnter2D( Coilder2D other){
        if(other.gameObject.tag=="Player"){
            RespawnEnemy();
        }

    



    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
