using UnityEngine;

public class OperationUsualUnit : MonoBehaviour
{
    private float _result;
    private readonly float _valueA = 0.1f;
    private readonly float _valueB = 0.2f;

    private void Update() => HardOperationForYourComputer();

    private void HardOperationForYourComputer() {
        for (int i = 0; i < 10000; i++) 
            _result = _valueA + _valueB;

        // Debug.Log(_result);
        _result = 0;
    }
}
