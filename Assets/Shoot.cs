using UnityEngine;
using System.Collections;

[RequireComponent (typeof (SteamVR_TrackedController))]
public class Shoot : MonoBehaviour {

    private SteamVR_TrackedController controller;
    public GameObject paintballPrefab;
    public float paintballVelocity;

	// Use this for initialization
	void Start () {
        controller = GetComponent<SteamVR_TrackedController>();
        controller.TriggerClicked += new ClickedEventHandler(FirePaintball);
	}
	
	// Update is called once per frame
	void Update () {
	    if (controller.triggerPressed)
        {
            
        }
	}

    void FirePaintball(object sender, ClickedEventArgs e)
    {
        Quaternion rotation = transform.rotation;
        GameObject paintball = (GameObject)Instantiate(paintballPrefab, transform.position, rotation);
        paintball.GetComponent<Rigidbody>().AddForce(paintball.transform.forward * paintballVelocity);
        Destroy(paintball, 2.0f);
    }
}
