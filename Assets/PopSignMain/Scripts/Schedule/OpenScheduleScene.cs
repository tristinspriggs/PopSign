using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenScheduleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openScheduleScene(string fromPage)
    {
        PlayerPrefs.SetString("From Page", fromPage);
        SceneManager.LoadScene("scheduling");
    }

    public void exitScheduleScene()
    {
        string target = PlayerPrefs.GetString("From Page", "map");
        SceneManager.LoadScene(target);
    }
}
