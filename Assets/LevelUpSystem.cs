using System.Collections;
using System.Collections.Generic;
using Unity.Entities;

public class LevelUpSystem : ComponentSystem
{
   protected override void OnUpdate()
   {
       // Entities.With(EntityQuery).ForEach( (Entity e, ref MyComponent c) => { /*do something*/ });
       Entities.ForEach( (Entity levelComponent, ref LevelComponent c) =>
       {
           levelComponent.level += 1;
       });

   }
}
