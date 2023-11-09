﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents.ItemEvents; 

[Table("DROP_ITEM_EVENTS")]
public class DropItemEvent : AItemEvent {
    public override string GetReadableType() {
        return "Drop Item Event";
    }
}