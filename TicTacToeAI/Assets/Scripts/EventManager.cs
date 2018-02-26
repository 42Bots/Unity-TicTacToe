using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*
 * Based on
 * https://unity3d.com/learn/tutorials/topics/scripting/events-creating-simple-messaging-system
 * 
 * and the example of creating a one argument version of UnityEvent
 * https://docs.unity3d.com/ScriptReference/Events.UnityEvent_1.html
*/


// create a custom class to allow passing an int as a paramerameter to an event
// up to 4 arguments can be used
// https://docs.unity3d.com/ScriptReference/Events.UnityEvent_4.html
// https://forum.unity.com/threads/messaging-system-passing-parameters-with-the-event.331284/
// more complex example, not used here:
// https://answers.unity.com/questions/593012/how-to-pass-on-information-through-c-events.html

[System.Serializable]
public class GameEvent : UnityEvent<int> {

}

public class EventManager : MonoBehaviour {

	private Dictionary <string, GameEvent> eventDictionary;
	private static EventManager eventManager;

	public static EventManager instance {
		get {
			if (!eventManager) {
				eventManager = FindObjectOfType (typeof(EventManager)) as EventManager;

				if (!eventManager) {
					Debug.LogError ("There needs to be one active EventManager script on a GameObject in your scene.");
				} else {
					eventManager.Init ();
				}
			}

			return eventManager;
		}
	}

	void Init()
	{
		if (eventDictionary == null) 
		{
			eventDictionary = new Dictionary<string, GameEvent> ();
		}
	}

	public static void StartListnening(string eventName, UnityAction<int> listener)
	{
		GameEvent thisEvent = null;

		if (instance.eventDictionary.TryGetValue (eventName, out thisEvent)) {
			thisEvent.AddListener (listener);
		} 
		else 
		{
			thisEvent = new GameEvent();
			thisEvent.AddListener (listener);
			instance.eventDictionary.Add (eventName, thisEvent);
		}
	}

	public static void StopListening (string eventName, UnityAction<int> listner)
	{
		if (eventManager == null) return;
		GameEvent thisEvent = null;
		if (instance.eventDictionary.TryGetValue (eventName, out thisEvent)) 
		{
			thisEvent.RemoveListener (listner);
		}
	}

	public static void TriggerEvent (string eventName, int tile)
	{
		GameEvent thisEvent = null;
		if (instance.eventDictionary.TryGetValue (eventName, out thisEvent)) 
		{
			thisEvent.Invoke (tile);
		}

	}
}
