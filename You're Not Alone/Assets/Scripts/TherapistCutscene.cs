using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TherapistCutscene : MonoBehaviour
{
    [Header("Dialog")]
    public TextMeshProUGUI therapistText;
    public TextMeshProUGUI mikeText;
    public GameObject mAudio;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dialog());
        therapistText.text = "";
        mikeText.text = "";
    }

    IEnumerator Dialog()
    {
        yield return new WaitForSeconds(2f);

        therapistText.text = "Therapist: Good morning Mike. How are we doing today?";

        yield return new WaitForSeconds(4f);

        therapistText.text = "";
        mikeText.text = "Mike: He was there again.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "";
        therapistText.text = "Therapist: The Demon?";

        yield return new WaitForSeconds(2f);

        therapistText.text = "";
        mikeText.text = "Mike: Yes. He came just as I woke up.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: He doesn’t ever leave me alone…";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: I just want this to end.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: Why don’t the meds and therapy help me? Why?";

        yield return new WaitForSeconds(4f);

        mikeText.text = "";
        therapistText.text = "Therapist: Well I could prescribe you a larger amount of the meds.";

        yield return new WaitForSeconds(4f);

        therapistText.text = "Therapist: But other than that, we can only wait.";

        yield return new WaitForSeconds(4f);

        therapistText.text = "Therapist: Have you done your home practices?";

        yield return new WaitForSeconds(4f);

        therapistText.text = "";
        mikeText.text = "Mike: Yeah, I have. They don’t work.";

        yield return new WaitForSeconds(4f);

        mikeText.text = "";
        therapistText.text = "Therapist: Come now Mike, you just gotta have patience,";

        yield return new WaitForSeconds(4f);

        therapistText.text = "Therapist: I believe we can get this to work out just fine.";

        yield return new WaitForSeconds(4f);

        therapistText.text = "";
        mikeText.text = "Mike: If you say so";

        yield return new WaitForSeconds(2f);

        mikeText.text = "";
        therapistText.text = "Therapist: I know so";

        yield return new WaitForSeconds(2f);

        therapistText.text = "Therapist: Maybe you could try to accept this demon of yours.";

        yield return new WaitForSeconds(4f);

        therapistText.text = "Therapist: Maybe by letting him truly in you can understand it,";

        yield return new WaitForSeconds(4f);

        therapistText.text = "Therapist: think like it does.";

        yield return new WaitForSeconds(2f);

        therapistText.text = "Therapist: Maybe by understanding it,";

        yield return new WaitForSeconds(2f);

        therapistText.text = "Therapist: you could try to begin shutting him down.";

        yield return new WaitForSeconds(3f);

        therapistText.text = "Therapist: Understand me Mike?";

        yield return new WaitForSeconds(2f);

        therapistText.text = "";
        mikeText.text = "Mike: Yeah, I think so. I could try that doc.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: Thanks.";

        yield return new WaitForSeconds(2f);

        mikeText.text = "";
        therapistText.text = "Therapist: I’m always here for you.";

        yield return new WaitForSeconds(3f);

        therapistText.text = "Therapist: See you next appointment. Go get some rest now.";

        yield return new WaitForSeconds(3f);

        therapistText.text = "";
        mikeText.text = "Mike: I will thanks.";

        yield return new WaitForSeconds(2f);

        therapistText.text = "";
        mikeText.text = "";
    }
}
