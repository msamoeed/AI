using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
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
            Instantiate(police, new Vector3(173,0,Random.Range(200,800)) , police.transform.rotation);

    }
}
