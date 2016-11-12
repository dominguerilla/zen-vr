using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class VRTeleportPoint : MonoBehaviour {

    [SerializeField]
    VRInteractiveItem vrItem;

    Renderer matRender;
    Material offMat;
    [SerializeField]
    Material onMat;

    [SerializeField]
    Material clickMat;

    [SerializeField]
    Transform TeleportSpot;
    Vector3 teleVector;

    [SerializeField]
    Transform teleportObj;

    [SerializeField]
    float defaultVerticalOffset = 1.0f;


    void Awake()
    {
        matRender = GetComponent<Renderer>();
        offMat = matRender.material;
    }

	// Use this for initialization
	void Start () {
        
        if (!TeleportSpot)
        {
            teleVector = this.gameObject.transform.up;
        }else
        {
            teleVector = TeleportSpot.position;
        }
        
        
        vrItem.OnClick += Teleport;
        vrItem.OnOver += OnOverHandle;
        vrItem.OnOut += OnOffHandle;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Teleport()
    {
        matRender.material = clickMat;
        teleportObj.gameObject.transform.position = teleVector;
    }

    void OnOverHandle()
    {
        matRender.material = onMat;
    }

    void OnOffHandle()
    {
        matRender.material = offMat;
    }
}
