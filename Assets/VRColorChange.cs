using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

[RequireComponent(typeof(VRInteractiveItem))]
public class VRColorChange : MonoBehaviour {

    VRInteractiveItem vrItem;
    Renderer materialRenderer;
    
    Material offMat;

    [SerializeField]
    Material onMat;

    [SerializeField]
    Material onDownMat;

    [SerializeField]
    Material onUpMat;


    void Awake()
    {
        vrItem = GetComponent<VRInteractiveItem>();
        materialRenderer = GetComponent<Renderer>();
    }


    void Start () {
        offMat = materialRenderer.material;

        vrItem.OnOver += HandleOnOver;
        vrItem.OnOut += HandleOnOut;
        vrItem.OnDown += HandleOnDown;
        vrItem.OnUp += HandleOnUp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void HandleOnOut()
    {
        materialRenderer.material = offMat;
    }

    void HandleOnOver()
    {
        materialRenderer.material = onMat;
    }

    void HandleOnDown()
    {
        materialRenderer.material = onDownMat;
    }

    void HandleOnUp()
    {
        materialRenderer.material = onUpMat;
    }

    void HandleSwipeRight()
    {

    }

    void HandleSwipeLeft()
    {

    }

    void HandleSwipeUp()
    {

    }

    void HandleSwipeDown()
    {

    }
}
