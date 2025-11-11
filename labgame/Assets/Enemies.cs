using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float maxSpeed=2;
    public int damage =1;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void Flip(){
        sr.filpX =!sr.filpX;
    }
    void Update()
    {
        
    }
}
