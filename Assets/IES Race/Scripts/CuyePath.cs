using UnityEngine;
using PathCreation;

public class CuyePath : MonoBehaviour
{
    [SerializeField] internal bool isWin = false;

    [SerializeField] internal PathCreator pathCreator;
    [SerializeField] internal EndOfPathInstruction endOfPathInstruction;

    [Space]
    [SerializeField] internal float speed;
    [SerializeField] internal float minSpeedRandom;
    [SerializeField] internal float maxSpeedRandom;
    
    private float distanceTravelled;

    private void Start() 
    {
        speed = Random.Range(minSpeedRandom, maxSpeedRandom);

        if (pathCreator != null)
        {
            pathCreator.pathUpdated += OnPathChanged;
        }
    }

    private void Update()
    {
        if (pathCreator != null)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
        }
    }

    private void OnPathChanged() => distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);

}
