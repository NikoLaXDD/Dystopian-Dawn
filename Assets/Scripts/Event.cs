using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Event : MonoBehaviour
{
    public string EventName { get; set; }
    public TMP_Text EventText { get; set; }
    
    public void SetDataEvent(EventObject eventObject)
    {
        EventName = eventObject.EventName;
        EventText.text = eventObject.EventText;
    }
}
