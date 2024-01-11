using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedGather : MonoBehaviour
{
    public GameObject targetPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(gameObject.transform.position, targetPosition.transform.position, 0.003f);
    }

    
    public void OnTriggerEnter(Collider other)
    {
        Invoke("FadeOut", 1);
        Invoke("NextScene", 2);
    }
    

    public void FadeOut()
    {
        GameObject.Find("Canvas").GetComponent<FadeOut>().Fadeout();
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Ending");
    }
}
