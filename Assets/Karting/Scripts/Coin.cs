using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : TargetObject
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        ValueManager.getInstance().addCoin();
        AudioUtility.CreateSFX(CollectSound, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
        Destroy(gameObject);
    }
}
