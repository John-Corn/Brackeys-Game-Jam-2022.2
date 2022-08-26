using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndCutscene : MonoBehaviour
{
    [Header("Dialog")]
    public TextMeshProUGUI demonText;
    public TextMeshProUGUI mikeText;
    public GameObject mAudio;
    public GameObject mAudio2;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement.playerControlsEnabled = false;
        StartCoroutine(Dialog());
        demonText.text = "";
        mikeText.text = "";
    }

    IEnumerator Dialog()
    {
        yield return new WaitForSeconds(1f);

        demonText.text = "Miiiiike, where have you beeen?!?!?";

        yield return new WaitForSeconds(3f);

        demonText.text = "You can’t just leave like that!";

        yield return new WaitForSeconds(3f);

        demonText.text = "";
        mikeText.text = "Mike: Breathe deep. In and out. phewww.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: Let him in, try to let him in.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: Hi there, I was at therapy.";

        yield return new WaitForSeconds(3f);

        mAudio2.SetActive(true);
        mikeText.text = "";
        demonText.text = "Why?";

        yield return new WaitForSeconds(2f);

        demonText.text = "You don’t need any therapy.";

        yield return new WaitForSeconds(3f);

        demonText.text = "You silly bastard.";

        yield return new WaitForSeconds(3f);

        demonText.text = "You have meeeeee.";

        yield return new WaitForSeconds(3f);

        demonText.text = "MEEEEEEEEEEEEEEEEEEEE";

        yield return new WaitForSeconds(3f);

        demonText.text = "YOU BASTARD. YOU CAN’T GO TO THERAPY.";

        yield return new WaitForSeconds(3f);

        demonText.text = "IT HAS NO USE.";

        yield return new WaitForSeconds(3f);

        demonText.text = "IT’S USELESS. USEEEEEELEESSSSS.";

        yield return new WaitForSeconds(3f);

        demonText.text = "DO you know what isn’t useless…";

        yield return new WaitForSeconds(3f);

        demonText.text = "";
        mikeText.text = "Mike: No, please no. Not that again.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "";
        demonText.text = "Oh yes, yes.";

        yield return new WaitForSeconds(3f);

        demonText.text = "Painting the walls of the upper floor room with your own shit.";

        yield return new WaitForSeconds(5f);

        mAudio2.SetActive(false);
        mAudio.SetActive(true);
        demonText.text = "I like when you do that.";

        yield return new WaitForSeconds(3f);

        demonText.text = "";
        mikeText.text = "Mike: Let him in, the doctor said. Well shit.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "";
        demonText.text = "AAAAALRIGGGHTTT!!!!";

        yield return new WaitForSeconds(3f);

        demonText.text = "";
        mikeText.text = "Mike: But only after I have gotten some rest.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "";
        demonText.text = "What? NO! YOU CAN'T DO THAT!";

        yield return new WaitForSeconds(3f);

        demonText.text = "YOU'RE ME AND YOU DO WHAT I TELL YOU TO DO!";

        yield return new WaitForSeconds(4f);

        demonText.text = "";
        mikeText.text = "Mike: NO! THIS IS MY BODY!";

        yield return new WaitForSeconds(3f);

        mikeText.text = "Mike: I WILL GO GET SOME REST!";

        yield return new WaitForSeconds(3f);

        mikeText.text = "";
        demonText.text = "ASSHOLE!";

        yield return new WaitForSeconds(3f);

        demonText.text = "I WILL NOT LET THIS ONE SLIDE!";

        yield return new WaitForSeconds(3f);

        demonText.text = "";
        mikeText.text = "Mike: You can't do nothing.";

        yield return new WaitForSeconds(3f);

        mikeText.text = "";
        demonText.text = "";

        PlayerMovement.playerControlsEnabled = true;

    }
}
