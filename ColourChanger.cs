using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    public int magic;
    public MeshRenderer cube;
    public void ChangeColour(int addEffect)

    {
        magic += addEffect;

        if (magic > 100)
        {
            cube.material.color = Color.cyan;
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeColour(10);     
            
        }
    }


}
