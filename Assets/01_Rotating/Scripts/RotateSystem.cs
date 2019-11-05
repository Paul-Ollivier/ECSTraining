using Unity.Jobs;
using Unity.Entities;
using Unity.Burst;
using Unity.Transforms;
using UnityEngine;

public class RotateSystem : JobComponentSystem
{
    [BurstCompile]
    private struct RotateJob : IJobForEach<RotationEulerXYZ, Rotate>
    {
        public float deltaTime;

        public void Execute(ref RotationEulerXYZ euler, ref Rotate rotate)
        {
            euler.Value += rotate.radiansPerSecond * deltaTime;
        }
    }

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var job = new RotateJob{ deltaTime = Time.deltaTime};
        return job.Schedule(this, inputDeps);
    }
}
