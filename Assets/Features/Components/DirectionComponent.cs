using Entitas;
using Entitas.CodeGeneration.Attributes;

[Event(EventTarget.Self)]
public sealed class DirectionComponent : IComponent
{
    public float value;
}
