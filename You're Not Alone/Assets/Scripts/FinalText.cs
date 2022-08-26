using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalText : MonoBehaviour
{
    [Header("Dialog")]
    public TextMeshProUGUI demonText;

    private void Start()
    {
        demonText.text = "";
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        yield return new WaitForSeconds(37f);

        demonText.text = "No matter what.";

        yield return new WaitForSeconds(3f);

        demonText.text = "You should never listen or do stuff told by toxic people.";

        yield return new WaitForSeconds(6f);

        demonText.text = "Even if they’re your own parents.";

        yield return new WaitForSeconds(4f);

        demonText.text = "You are your own human being.";

        yield return new WaitForSeconds(4f);

        demonText.text = "If you or anyone you know is having a hard time.";

        yield return new WaitForSeconds(5f);

        demonText.text = "Remember, you’re not alone.";

        yield return new WaitForSeconds(4f);

        demonText.text = "If things go super hard, you can always contact your country's CRISIS Helpline or other medical services.";

        yield return new WaitForSeconds(8f);

        demonText.text = "Your life and others' lives are worth living.";

        yield return new WaitForSeconds(5f);

        demonText.text = "Trust the change will come. Because it will.";

        yield return new WaitForSeconds(5f);

        demonText.text = "Trust.";

        yield return new WaitForSeconds(3f);

        demonText.text = "Listen.";

        yield return new WaitForSeconds(3f);

        demonText.text = "Talk.";

        yield return new WaitForSeconds(3f);

        demonText.text = "Created by: Joonatan “JohnCorn” Kytönen";

        yield return new WaitForSeconds(5f);

        demonText.text = "Music and sounds from: Freesound.org";

        yield return new WaitForSeconds(5f);

        demonText.text = "Thanks for playing.";

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("Menu");
    }
}
