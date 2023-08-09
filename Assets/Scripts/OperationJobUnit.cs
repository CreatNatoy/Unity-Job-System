using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class OperationJobUnit : MonoBehaviour
{
    private readonly float _valueA = 0.1f;
    private readonly float _valueB = 0.2f;

    private NativeArray<float> _result;
    private JobHandle _jobHandle;
    private void Start() {
        _result = new NativeArray<float>(1, Allocator.Persistent);
    }

    private void OnDestroy() {
        _result.Dispose();
    }

    private void Update() {
        var operationJob = new OperationJob() {
            ValueA = _valueA,
            ValueB = _valueB,
            Result = _result
        };

        _jobHandle = operationJob.Schedule();
    }

    private void LateUpdate() {
        _jobHandle.Complete();
   //     Debug.Log(_result[0]);
    }
}