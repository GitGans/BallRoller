using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTargets : MonoBehaviour
{   
    public GameObject[] obj;
    
    // Start is called before the first frame update
    void Start()
    {
        Create();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Create() 
        {
            for (int i = 0; i < 5; i++) 
            {
                Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), 0.25f, RandomNumber()), Quaternion.Euler(0, RandomNumberE(), 0));
            }
        }

    float RandomNumber() 
        {
            return UnityEngine.Random.Range(-4.5f, 4.5f);
        }  
    int RandomNumberE() 
        {
            return UnityEngine.Random.Range(0, 90);
        }  


}

