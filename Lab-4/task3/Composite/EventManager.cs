using System;
using System.Collections.Generic;

namespace Composite;

public class EventManager
{
    private Dictionary<string, List<IEventListener>> _listeners = new Dictionary<string, List<IEventListener>>();

    public void Subscribe(string eventType, IEventListener listener)
    {
        if (!_listeners.ContainsKey(eventType))
        {
            _listeners[eventType] = new List<IEventListener>();
        }
        _listeners[eventType].Add(listener);
    }

    public void Unsubscribe(string eventType, IEventListener listener)
    {
        if (_listeners.ContainsKey(eventType))
        {
            _listeners[eventType].Remove(listener);
        }
    }

    public void Notify(string eventType, LightNode node)
    {
        if (_listeners.ContainsKey(eventType))
        {
            foreach (var listener in _listeners[eventType])
            {
                if (node is LightElementNode elementNode)
                {
                    listener.OnEvent(eventType, elementNode);
                }
            }
        }
    }
} 