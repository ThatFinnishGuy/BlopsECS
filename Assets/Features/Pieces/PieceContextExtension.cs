using UnityEngine;

public static class PieceContextExtension
{
    public static GameEntity CreateRandomPiece(this GameContext context, int x, int y)
    {
        var entity = context.CreateEntity();
        entity.isPiece = true;
        entity.isMovable = true;
        entity.isInteractive = true;
        entity.AddPosition(new Vector2Int(x, y));
        entity.AddAsset("Blop");
        return entity;
    }
}
