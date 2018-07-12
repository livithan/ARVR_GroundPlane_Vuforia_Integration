using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MoveButton : MonoBehaviour {

	public RectTransform button;
	public float selectedPosZ = -200f;

    private List<RectTransform> optionsTglsRT = new List<RectTransform>();

    // Use this for initialization
    void Start () {
        GatherOptionsTogglesRT();

    }

    private void GatherOptionsTogglesRT()
    {
        /*
        foreach (Transform child in transform)
        {
            if (child.CompareTag("OptionsToggle"))
                optionsTglsRT.Add(child.gameObject.GetComponent<RectTransform>());
        }
        */
        Transform[] allChildren = GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren) {
            if (child.gameObject.tag == "OptionsToggle") {
                optionsTglsRT.Add(child.gameObject.GetComponent<RectTransform>());
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

	public void MoveTheButton(bool b){
		if(b){
            button.DOLocalMoveZ(selectedPosZ, 0.25f);
			//button.localPosition.z = selectedPosZ;
		}else{
            //button.localPosition.z = 0f;
            button.DOLocalMoveZ(0f, 0.25f);
        }
	}

    public void MoveTheButtonOff(bool b)
    {
        if (!b)  
        {
            foreach (RectTransform rt in optionsTglsRT) {
                rt.DOLocalMoveZ(0f, 0.25f);
            }
        }
    }
}
