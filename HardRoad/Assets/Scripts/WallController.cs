using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MilkShake;

public class WallController : MonoBehaviour
{
    [SerializeField]
    private ShakePreset shakerPreset;

    private void Update()
    {
        transform.position += new Vector3(0, 0, -1 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "EndPoint")
        {
            PoolController.Despawn(this.gameObject);
        }

        if (collider.gameObject.tag == "Player")
        {
            HealthAction.Instance.TakeDamage();
            Shaker.ShakeAll(shakerPreset);
            PoolController.Despawn(this.gameObject);
        }
    }
}
