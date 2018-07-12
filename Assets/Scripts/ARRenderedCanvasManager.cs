using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ARRenderedCanvasManager : MonoBehaviour {

    public CanvasGroup arRenderCanvas;
    public float transitionTime = 1.25f;

    // Use this for initialization
    void Start() {
        arRenderCanvas = transform.GetComponent<CanvasGroup>();

    }

    // Update is called once per frame
    void Update() {

    }

    public void FadeCanvas(bool b) {
        Debug.Log("BANG!");
        StartCoroutine(DOFadeCanvas(b));
    }

    IEnumerator DOFadeCanvas(bool b) {
        if (b)
        {
            arRenderCanvas.alpha = 0f;
            arRenderCanvas.DOFade(1f, transitionTime);
        }
        else {
            arRenderCanvas.alpha = 1f;
            arRenderCanvas.DOFade(0f, transitionTime);
        }
        yield return new WaitForSeconds(transitionTime);
    }
}
