using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePickingComfirmScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TimePickerScript hour, minute, noon;
    public Text target;
    public GameObject picker;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void handleComfirmClicked()
    {
        string result = "";
        result += hour.getValue() + ":";
        result += minute.getValue() + " ";
        result += noon.getValue();
        target.text = result;
        picker.SetActive(false);
    }
}
