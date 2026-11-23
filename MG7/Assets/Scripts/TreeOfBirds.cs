using System.Runtime.CompilerServices;
using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _birds;
    [SerializeField] private GameObject[] _player;
    [SerializeField] private float _interactionDistance = 5f;


    void Update()
    {
        foreach (GameObject bird in _birds)
        {
            if (Vector3.Distance(_player[0].transform.position, bird.transform.position) < _interactionDistance)
            {
                bird.SetActive(true);
            }
        }

    }

}
