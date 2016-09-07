using UnityEngine;
using System.Collections;

public class HitDetector : MonoBehaviour {
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("paintball"))
        {
            GameManager.incrementScore();
            Destroy(col.gameObject);
        }
    }
}
