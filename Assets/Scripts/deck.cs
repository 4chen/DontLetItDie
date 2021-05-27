using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deck : MonoBehaviour
{
    public List<string> cards = new List<string>();
    public List<string> disCards = new List<string>();
    public int randomSelector;
    public GameObject meat, campFire, wood, cheat, anim, UpGradeAnim, upgradeScore, cooldown;
    public Text gotCard;
    public Sprite OnButton, OffButton;
    float randValue;

    private void Start()
    {
        meat =         GameObject.Find("meat");
        campFire =     GameObject.Find("Campfire");
        wood =         GameObject.Find("woodPile");
        cheat =        GameObject.Find("cheatobject");
        anim =         GameObject.Find("Cooldown");
        UpGradeAnim =  GameObject.Find("UpgradePoint");
        upgradeScore = GameObject.Find("Upgrademenu");
        cooldown =     GameObject.Find("Cooldown");

        cooldown.SetActive(false);
    }

    // take a resource from the resource deck
    public void drawCard()
    {
        cooldown.SetActive(true);
        //if deck is empty, add the discard pile to the deck
        if (cards.Count == 0)
        {
            discardCard();
        }
        
        randomSelector = Random.Range(0,cards.Count);
        gotCard.text = cards[randomSelector];

        //if a meat was drawn
        if (cards[randomSelector] == "meat")
        {
            //get moddifier from GetComponent<Upgrademenu>().meat that increases the mount of resources you get
            meat.GetComponent<meatPile>().AddMeat(upgradeScore.GetComponent<UpgradeMenu>().MeatInc);
            randValue = Random.value;
            if (randValue < .45f)
            {
                
                CheckPoint();
            }
        }

        //if a wood was drawn
        if (cards[randomSelector] == "wood")
        {
            //get moddifier from GetComponent<Upgrademenu>().wood that increases the mount of resources you get
            wood.GetComponent<woodPile>().AddWood(upgradeScore.GetComponent<UpgradeMenu>().WoodInc);
            randValue = Random.value;
            if (randValue < .45f)
            {               
                CheckPoint();
            }
        }

        //if nothing was drawn
        if (cards[randomSelector] == "nothing")
        {
            discardCard();
        }

        //add the drawn card to the discard pile
        disCards.Add(cards[randomSelector]);

        //remove the drawn card from the deck
        cards.RemoveAt(randomSelector);

        //add time to the clock
        cheat.GetComponent<CheetSheet>().AddTime( 1 );

        //dissable the button for cooldown
        GetComponent<Button>().enabled = false;
        GetComponent<Button>().image.sprite = OffButton;
        anim.GetComponent<Animator>().SetBool("play",true);
        StartCoroutine(coolDownEnd(anim.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length));
    }

    public void CheckPoint()
    {
        upgradeScore.GetComponent<UpgradeMenu>().upgradePoints++;
        UpGradeAnim.GetComponent<Animator>().SetBool("play", true);
        StartCoroutine(upgradePointGot(.16f));
    }

    //take all cards from the discard pile and add them to the deck
    public void discardCard()
    {
        for (int i = 0; i < disCards.Count; i++)
        {
            cards.Add(disCards[0]);
            disCards.RemoveAt(0);
        }
    }

    IEnumerator coolDownEnd(float delay)
    {
        yield return new WaitForSeconds(delay);

        anim.GetComponent<Animator>().SetBool("play", false);
        GetComponent<Button>().image.sprite = OnButton;
        GetComponent<Button>().enabled = true;
        cooldown.SetActive(false);
    }

    IEnumerator upgradePointGot(float delay)
    {
        yield return new WaitForSeconds(delay);

        UpGradeAnim.GetComponent<Animator>().SetBool("play", false);
    }
}
