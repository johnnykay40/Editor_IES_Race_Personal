using System.Collections.Generic;
using UnityEngine;

public class EndPath : MonoBehaviour
{
    [SerializeField] private CuyePath cuyePathAlone;
    [SerializeField] private List<CuyePath> cuyePath;

    private void OnTriggerEnter(Collider other)
    {
        cuyePathAlone = other.gameObject.GetComponent<CuyePath>();

        if (other.CompareTag("Cuye"))
        {
            cuyePath.Add(cuyePathAlone);
        }
    }
}
