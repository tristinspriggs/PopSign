using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePickerScript : MonoBehaviour
{
    public Text textPrefab;
    public GameObject content;
    public GameObject pickerFrame;
    protected ArrayList choices = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public string getValue()
    {
        double minDistance = 1000000;
        int index = -1;
        Vector3 pointA = pickerFrame.transform.position;
        for (int i = 0; i < choices.Count; i++)
        {
            Vector3 pointB = ((Text)(choices[i])).transform.position;
            double distance = Vector3.Distance(pointA, pointB);
            if (distance < minDistance)
            {
                minDistance = distance;
                index = i;
            }
        }

        return ((Text)(choices[index])).text;
    }
}
