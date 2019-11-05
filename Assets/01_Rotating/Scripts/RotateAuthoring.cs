using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using static Unity.Mathematics.math;

public class RotateAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
    [SerializeField] private float degreesPerSecond;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new Rotate { radiansPerSecond = Unity.Mathematics.math.radians(degreesPerSecond)});
        dstManager.AddComponentData(entity, new RotationEulerXYZ());
    }
}
