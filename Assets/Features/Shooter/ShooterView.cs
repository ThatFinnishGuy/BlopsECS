using UnityEngine;


public class ShooterView : View
{
    public LineRenderer lineRenderer;

    public override void OnDirection(GameEntity entity, float dir)
    {
        transform.rotation = Quaternion.AngleAxis(dir - 90, Vector3.forward);
    }

    protected override void destroy()
    {
        base.destroy();
    }
}
