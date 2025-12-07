using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FlashGreen : MonoBehaviour
{
    private Color originalColor;

    public float flashDuration = 0.4f;

    public IEnumerator FlashColor(Image labelToFlash, Color flashColor)
    {
        originalColor = labelToFlash.color;
        labelToFlash.color = flashColor;
        yield return new WaitForSeconds(flashDuration);
        labelToFlash.color = originalColor;
    }
}
