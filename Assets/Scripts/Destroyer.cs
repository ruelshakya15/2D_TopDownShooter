using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float lifeTime;//destroy sound object as to not clutter the game scene
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

}
