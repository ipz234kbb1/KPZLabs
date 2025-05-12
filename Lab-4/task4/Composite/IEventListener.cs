namespace Composite;

public interface IEventListener
{
    void OnEvent(string eventType, LightElementNode element);
} 