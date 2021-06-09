using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourPickerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textPrefab;
    public GameObject content;
    public GameObject pickerFrame;

    void Start()
    {
        for (int i = 1; i <= 12; i++)
        {
            Text text = Text.Instantiate(textPrefab);
            text.text = i + " ";
            text.transform.parent = content.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
