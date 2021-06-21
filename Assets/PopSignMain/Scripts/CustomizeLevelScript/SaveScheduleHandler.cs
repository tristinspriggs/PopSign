using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScheduleHandler : MonoBehaviour
{
    public Dropdown scheduleType;
    public Text scheduledTime;
    public Toggle[] scheduledDay;
    public OpenScheduleScene closeObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveSchedule()
    {
        int typeIndex = scheduleType.value;

        if (typeIndex == 0)
        {
            PlayerPrefs.SetString("Schedule Type", "None");
            // Delete notifications
        }
        else if (typeIndex == 1)
        {
            PlayerPrefs.SetString("Schedule Type", "Daily");
            parseTime();      
            // Set repeatable notifications for everyday
        }
        else
        {
            PlayerPrefs.SetString("Schedule Type", "Weekly");
            parseTime();
            string[] dayOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < 7; i++)
            {
                Toggle theToggle = scheduledDay[i];
                string theDay = dayOfWeek[i];

                if (theToggle.isOn)
                {
                    PlayerPrefs.SetInt(theDay, 1);
                }
                else
                {
                    PlayerPrefs.SetInt(theDay, 0);
                }
            }
            // Set weekly notification
        }

        closeObject.exitScheduleScene();

    }

    private void parseTime()
    {
        string rawString = scheduledTime.text;
        int hour = int.Parse(rawString.Substring(0, rawString.IndexOf(":")));
        int minute = int.Parse(rawString.Substring(rawString.IndexOf(":") + 1, rawString.IndexOf(" ") - 2));
        hour = hour == 12 ? 0 : hour;
        hour = rawString.Contains("AM") ? hour : hour + 12;

        Debug.Log(hour);
        Debug.Log(minute);
        PlayerPrefs.SetInt("Hour", hour);
        PlayerPrefs.SetInt("Minute", minute);
    }
}
