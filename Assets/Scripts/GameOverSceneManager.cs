using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryButtonClicked() {
        Invoke("LoadScene", 1.0f);
    }

    public void LoadScene() {
        SceneManager.LoadScene("ToyHouse");
    }

}
