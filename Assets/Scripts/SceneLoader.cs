using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public string SceneName;

    public BoxCollider2D Collider2D;

    public void OnTriggerEnter2D(Collider2D other)
    { 
        SceneManager.LoadScene(SceneName);
        
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
