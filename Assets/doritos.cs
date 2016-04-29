using UnityEngine;
using System.Collections;

public class doritos : MonoBehaviour
{

    public mlgVision Instance;

    void OnTriggerEnter(Collider other)
    {
        Instance.hasDorito = true;
        this.gameObject.SetActive(false);
    }
}
