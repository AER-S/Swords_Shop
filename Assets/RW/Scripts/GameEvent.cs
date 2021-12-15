using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Game Event", fileName = "NewGameEvent", order = 52)]
public class GameEvent : ScriptableObject
{
    private HashSet<GameEventListener> listeners = new HashSet<GameEventListener>();

    public void Raise()
    {
        foreach (GameEventListener listener in listeners)
        {
            listener.OnEventRaised();
        }
    }

    public void RegisterListener(GameEventListener _listener) => listeners.Add(_listener);
    public void UnregisterListener(GameEventListener _listener) => listeners.Remove(_listener);
}
