using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;
using DG.Tweening;

public class RadialButtonLayoutControl : MonoBehaviour {

    //public RadialLayout radialLayout;
    public float delayTime = 0.25f;
    public float transitionTime = 0.75f;

    private List<GameObject> optionsToggle = new List<GameObject>();

    // Use this for initialization
    void Start() {
        GatherOptionsToggles();
        OptionsTogglesDisplay(false);
    }

    private void GatherOptionsToggles()
    {
        foreach (Transform child in transform)
        {
            if (child.CompareTag("OptionsToggle"))
                optionsToggle.Add(child.gameObject);
        }
    }

    public void OptionsTogglesDisplay(bool b) {
        StartCoroutine(DOOptionsTogglesDisplay(b));
    }

    IEnumerator DOOptionsTogglesDisplay(bool b) {
        foreach (GameObject go in optionsToggle) {
            Transform t = go.GetComponent<Transform>();

            if (b)
            {
                t.DOScale(1f, transitionTime);
            }
            else
            {
                t.DOScale(0f, transitionTime);
            }
            yield return new WaitForSeconds(0.01f);
        }
        

        yield return new WaitForSeconds(transitionTime);
    }

    // Update is called once per frame
    void Update () {
    }
}


