using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionManager : MonoBehaviour
{
    CubeSript cubeData;

    void OnCollisionEnter(Collision col)
    {
        cubeData = col.gameObject.GetComponent<CubeSript>();
        Debug.Log("Colisión con " + cubeData.cubename);
        Debug.Log("Con valor de " + cubeData.value);
    }
}
