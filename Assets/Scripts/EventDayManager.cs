using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EventDayManager : MonoBehaviour
{
    public List<EventObject> eventDayList = new();

    public static EventDayManager Instance;

    public EventDayManager()
    {
        Instance = this;
    }

    public void Start()
    {
        var eventDayDataLists = Resources.LoadAll<EventScriptableObjects>("DayEvent");

        foreach (var eventDayDataList in eventDayDataLists)
        {
            var eventDayObj = new EventObject(eventDayDataList);
            eventDayList.Add(eventDayObj);
            Debug.Log(eventDayObj.EventName);
        }
    }
}
