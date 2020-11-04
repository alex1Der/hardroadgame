using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAction : MonoBehaviour
{
    public List<GameObject> heartList;

    public static HealthAction Instance { get; private set; }
        
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this; 
        }
        else 
        {
            PoolController.Despawn(gameObject); 
        }
    }

    public void TakeDamage()
    {
        heartList[heartList.Count - 1].SetActive(false);
        heartList.Remove(heartList[heartList.Count - 1]);

        if (heartList.Count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
