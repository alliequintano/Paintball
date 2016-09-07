using UnityEngine;
using System.Collections;

public class HitDetector : MonoBehaviour {
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("paintball"))
        {
            MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
            Material material = renderer.material;
            material.color = GameManager.paintColor;
            GameManager.incrementScore();
            Destroy(col.gameObject);
        }
    }
}
