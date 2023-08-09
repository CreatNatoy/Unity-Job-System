using UnityEngine;

public class SpawnGameObject : MonoBehaviour
{
    [SerializeField] private int _countObjects = 1000;
    [SerializeField] private GameObject _prefab; 

    private void Start() => Spawn();

    private void Spawn() {
        int positionX = 0;
        int positionY = 0;
        int valueIncrease = 1; 
        
        for (int i = 0; i < _countObjects; i++) {

            if (positionY < valueIncrease)
                positionY++;
            else if (positionX < 100)
                positionX++;
            else {
                positionX = 0;
                positionY = 0;
                valueIncrease++;
            }

            var position = new Vector3(positionX, positionY, 0);
            Instantiate(_prefab, position, Quaternion.identity, transform);
        }
        
        gameObject.SetActive(false);
    }
}
