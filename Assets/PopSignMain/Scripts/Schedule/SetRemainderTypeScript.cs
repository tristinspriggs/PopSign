using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRemainderTypeScript : MonoBehaviour
{
    public GameObject dailyEditor, weeklyEditor;
    public Dropdown target;

    // Start is called before the first frame update
    void Start()
    {
        string remainderType = PlayerPrefs.GetString("Schedule Type");
        if (remainderType == "Daily")
        {

        }
        else if (remainderType == "Weekly")
        {

        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onRemainderTypeChanged()
    {
        if (target.value == 0)
        {
            dailyEditor.SetActive(false);
            weeklyEditor.SetActive(false);
        }
        else if (target.value == 1)
        {
            dailyEditor.SetActive(true);
            weeklyEditor.SetActive(false);
        }
        else if (target.value == 2)
        {
            dailyEditor.SetActive(true);
            weeklyEditor.SetActive(true);
        }
    }
}
