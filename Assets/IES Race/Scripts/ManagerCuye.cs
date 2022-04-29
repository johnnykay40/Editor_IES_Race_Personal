using System.Collections.Generic;
using UnityEngine;

public class ManagerCuye : MonoBehaviour
{
    [SerializeField] private CuyePath cuyeWin;
    [SerializeField] private List<CuyePath> cuyes;

    [SerializeField] private int indexRandomcuye;

    [Range(0,100)]
    [SerializeField] private float timeAddWin;
    [Range(0,10)]
    [SerializeField] private float howMuchSpeedAdd;

    private void Start()
    {
        indexRandomcuye = Random.Range(0, cuyes.Count);

        Invoke(nameof(GetRandomCuye), timeAddWin);
    }

    private void GetRandomCuye()
    {
        cuyes[indexRandomcuye].isWin = true;
        cuyeWin = cuyes[indexRandomcuye];

        cuyeWin.speed += howMuchSpeedAdd;
    }
}
