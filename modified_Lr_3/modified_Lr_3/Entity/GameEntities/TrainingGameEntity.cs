﻿namespace modified_Lr_3.Entity.GameEntities;

public class TrainingGameEntity : GameEntity
{
    public TrainingGameEntity(int playerId)
    {
        ChangeOfRating = 0;
        PlayerId = playerId;
    }
}