using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject police; 

    // Start is called before the first frame update
    void Start()
    {
          InvokeRepeating("Spawn", 5, 5);

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void Spawn(){
            Instantiate(police, new Vector3(-293 ,1,Random.Range(200,400)) , police.transform.rotation);

    }
}
