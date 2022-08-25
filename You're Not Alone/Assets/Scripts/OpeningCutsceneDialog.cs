using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OpeningCutsceneDialog : MonoBehaviour
{
    [Header("Dialog")]
    public TextMeshProUGUI demonText;
    public TextMeshProUGUI mikeText;
    public GameObject mAudio;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement.playerControlsEnabled = false;
        StartCoroutine(Dialog());
        demonText.text = "";
        mikeText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Dialog()
    {
        yield return new WaitForSeconds(2f);

        demonText.text = "You’re finally awake.";

        yield return new WaitForSeconds(3f);

        demonText.text = "I was beginning to wonder if you ever woke up.";

        yield return new WaitForSeconds(4f);

        demonText.text = "That wouldn't be nice now, would it?";

        yield return new WaitForSeconds(3f);

        demonText.text = "To leave me all alone here… Would it Mike?";

        yield return new WaitForSeconds(3f);

        demonText.text = "Would it? Would it? WOULD IT!?";

        yield return new WaitForSeconds(3f);

        demonText.text = "";
        mikeText.text = "Mike: STOP IT!";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: Please why won’t you leave. Leave me alone, please.";

        yield return new WaitForSeconds(4f);

        //Maniac laughter
        mikeText.text = "";
        mAudio.SetActive(true);
        demonText.text = "Leave you alone?";

        yield return new WaitForSeconds(3f);
        mAudio.SetActive(false);

        demonText.text = "Why would I do that Mike?";

        yield return new WaitForSeconds(3f);

        demonText.text = "I like it here.";
        mAudio.SetActive(true);

        yield return new WaitForSeconds(3f);
        mAudio.SetActive(false);

        //Maniac laughter

        //Mubling noices
        demonText.text = "";
        mikeText.text = "Mike: *mubling*";

        yield return new WaitForSeconds(2f);

        mikeText.text = "";
        demonText.text = "What’d you say Mike?";

        yield return new WaitForSeconds(2f);

        demonText.text = "";
        mikeText.text = "Mike: One, two, three, four. I’m all right. I’m all right.";

        yield return new WaitForSeconds(4f);

        mikeText.text = "Mike: Everything is just fine.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: I’m standing next to my bed, I can feel the floor under me";

        yield return new WaitForSeconds(4f);

        mikeText.text = "Mike: ...And...";

        yield return new WaitForSeconds(2f);

        mikeText.text = "Mike: Oh shit and I have an appointment soon, gotta go..";

        yield return new WaitForSeconds(4f);

        demonText.text = "";
        mikeText.text = "";

        PlayerMovement.playerControlsEnabled = true;

    }
}
