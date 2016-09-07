using UnityEngine;
using System.Collections;

public class HitDetector : MonoBehaviour {

    public GameObject paintballSplatPrefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("paintball"))
        {
            MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
            Material material = renderer.material;
            material.color = GameManager.paintColor;
            GameManager.incrementScore();
            GameObject paintballSplat = (GameObject)Instantiate(paintballSplatPrefab, col.transform.position, col.transform.rotation);
            Destroy(col.gameObject);
            Destroy(paintballSplat, 5.0f);
        }
    }
}
