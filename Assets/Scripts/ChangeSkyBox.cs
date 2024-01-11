using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyBox : MonoBehaviour
{
    public Material mat;
    // Start is called before the first frame update
    
    void Start()
    {
        GameObject cam = GameObject.Find ("Main Camera");
        cam.GetComponent<Skybox> ().material = mat;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
