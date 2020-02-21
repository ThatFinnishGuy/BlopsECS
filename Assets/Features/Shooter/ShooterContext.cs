using UnityEngine;

public static class ShooterContext
{
    public static GameEntity CreateShooter(this GameContext context, int x, int y, float dir)
    {
        var entity = context.CreateEntity();
        entity.isPiece = false;
        entity.isMovable = false;
        entity.isInteractive = false;
        entity.AddPosition(new Vector2Int(x, y));
        entity.AddDirection(dir);
        return entity;
    }
}
