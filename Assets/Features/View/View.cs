using Entitas;
using Entitas.Unity;
using UnityEngine;

public class View : MonoBehaviour, IView, IPositionListener, IDirectionListener, IDestroyedListener
{
    public virtual void Link(IEntity entity)
    {
        gameObject.Link(entity);
        var e = (GameEntity)entity;
        e.AddPositionListener(this);
        e.AddDirectionListener(this);
        e.AddDestroyedListener(this);
        var pos = e.position.value;
        transform.localPosition = new Vector3(pos.x, pos.y);
        var dir = e.direction.value;
        transform.rotation = Quaternion.AngleAxis(dir - 90, Vector3.forward);
    }

    public virtual void OnPosition(GameEntity entity, Vector2Int value)
    {
        transform.localPosition = new Vector3(value.x, value.y);
    }

    public virtual void OnDirection(GameEntity entity, float dir)
    {
        transform.rotation = Quaternion.AngleAxis(dir - 90, Vector3.forward);
    }

    public virtual void OnDestroyed(GameEntity entity)
    {
        destroy();
    }

    protected virtual void destroy()
    {
        gameObject.Unlink();
        Destroy(gameObject);
    }
}
