using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public GameObject healthPoints;
    
    public void SpawnHealth(){
        StartCoroutine(SpawnHealthAfterTime());
    }

    IEnumerator SpawnHealthAfterTime(){
        yield return new WaitForSeconds(Random.Range(3f,8f));

        GameObject health = Instantiate(healthPoints, this.transform);
        health.transform.localPosition = new Vector3(Random.Range(-10,10),1,Random.Range(-10,10));
    }
}
