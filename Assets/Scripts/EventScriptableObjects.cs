using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "SpawnManagerScriptableObject", order = 0)]
public class EventScriptableObjects : ScriptableObject
{
    public string eventName;
    public string eventText;
}
