using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : MonoBehaviour
{
    [SerializeField] GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.R))
        {
            
            SphereChanger.RandomiseColour(this.gameObject);

        }

        if (Input.GetKey(KeyCode.Z))
        {

            transform.localScale = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        }

        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(new Vector3(Random.Range(-25f, 25f), Random.Range(-25f, 25f), Random.Range(-25f, 25f)));
        }

        //if (Input.GetKeyDown(KeyCode.M))
        if (Input.GetKey(KeyCode.M))
        {

            SphereChanger.OnFire(fire, this.transform);
            // Instantiate(fire, transform.position, Quaternion.identity);
        }
        
    }
}
