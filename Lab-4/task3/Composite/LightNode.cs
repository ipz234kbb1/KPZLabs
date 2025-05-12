namespace Composite;

public abstract class LightNode
{
    protected EventManager _eventManager;

    protected LightNode()
    {
        _eventManager = new EventManager();
    }

    public void AddEventListener(string eventType, IEventListener listener)
    {
        _eventManager.Subscribe(eventType, listener);
    }

    public void RemoveEventListener(string eventType, IEventListener listener)
    {
        _eventManager.Unsubscribe(eventType, listener);
    }

    protected void TriggerEvent(string eventType)
    {
        _eventManager.Notify(eventType, this);
    }

    public abstract string OuterHTML { get; }
}