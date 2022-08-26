using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quote : MonoBehaviour
{
    [Header("Dialog")]
    public TextMeshProUGUI quote;
    public GameObject mAudio;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dialog());
        quote.text = "";
    }

    IEnumerator Dialog()
    {
        yield return new WaitForSeconds(2f);

        quote.text = "Are you sure you're real";

        yield return new WaitForSeconds(3f);

        quote.text = "Am I real";

        yield return new WaitForSeconds(2f);

        quote.text = "What even is real...";

        yield return new WaitForSeconds(3f);

        quote.text = "real...";

        yield return new WaitForSeconds(2f);

        quote.text = "rl...";

        yield return new WaitForSeconds(1f);

        mAudio.SetActive(true);
        quote.text = "rlllllllllllllllllllllllllllllllllllll";

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("Opening Cutscene");
    }
}
