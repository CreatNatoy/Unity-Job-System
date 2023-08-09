using Unity.Collections;
using Unity.Jobs;
using Unity.Burst;

[BurstCompile]
public struct OperationJob : IJob
{
    [ReadOnly]
    public float ValueA;
    [ReadOnly]
    public float ValueB;
    [WriteOnly]
    public NativeArray<float> Result; 

    public void Execute() {
        float result = 0f;
        for (int i = 0; i < 10000; i++) 
            result = ValueA + ValueB;
        Result[0] = result; 
    }
}