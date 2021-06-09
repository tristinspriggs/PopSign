using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeOfDayPickerScript : MonoBehaviour
{
    public Text textPrefab;
    public GameObject content;
    public GameObject pickerFrame;
    private ArrayList choices = new ArrayList();

    void Start()
    {
        for (int i = 1; i <= 6; i++)
        {
            Text text = Text.Instantiate(textPrefab);
            text.text = "";
            if (i == 3)
            {
                text.text = "AM";
                choices.Add(text);
            }
            if (i == 4)
            {
                text.text = "PM";
                choices.Add(text);
            }
            text.transform.parent = content.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
