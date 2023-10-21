using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EventObject
{
    public string EventName { get; set; }
    public string EventText { get; set; }

    public EventObject(EventScriptableObjects eventScriptableObjects)
    {
        eventScriptableObjects.eventName = EventName;
        eventScriptableObjects.eventText = EventText;
    }
}
