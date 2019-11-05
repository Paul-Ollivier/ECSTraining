using System.Collections;
using UnityEngine;
using Unity.Entities;

public class Testing : MonoBehaviour
{
    private void Start()
    {
        var entityManager = World.Active.EntityManager;
        var entity = entityManager.CreateEntity(typeof(LevelComponent));

        entityManager.SetComponentData(entity, new LevelComponent { level = 10 });
    }

    void Update()
    {
        
    }
}
