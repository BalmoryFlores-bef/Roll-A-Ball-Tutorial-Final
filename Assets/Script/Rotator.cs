using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (15,30,45) * Time.deltaTime);
    }
}
