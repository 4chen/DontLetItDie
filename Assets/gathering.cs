using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gathering : MonoBehaviour
{
    private bool _Bag, _Hatchet, _PickAxe;
    public Sprite[] _resources;
    public Image _randomResource;
    private int _randNumb, _subRand;
    private playerInventory _playerInv;
    public GameObject _button;
    private GameObject _soundLib;

    public List<string> cards = new List<string>();
    public List<string> disCards = new List<string>();
    public int randomSelector;

    public Sprite[] _buttonstate;
    public GameObject _floatResource;

    public bool _activeBag, _activeHatchet, _activePickaxe;

    public float _sliderValue;

    private void OnEnable()
    {
        _randNumb = Random.Range(0, _resources.Length);
        _playerInv = GameObject.Find("playerInventory").GetComponent<playerInventory>();
        _button = GameObject.Find("Button (1)");
        _soundLib = GameObject.Find("SoundLibrary");
    }

    public void Validate(string activeToggle)
    {
        switch (activeToggle)
        {
            case ("Item(1)"): // Empty
                _button.GetComponent<Image>().sprite = _buttonstate[1];
                _button.GetComponent<Button>().interactable = true;
                _activeBag = false;
                _activeHatchet = false;
                _activePickaxe = false;
                break;
            case ("Item(2)"): // Bag
                _button.GetComponent<Image>().sprite = _buttonstate[1];
                _button.GetComponent<Button>().interactable = true;
                _activeBag = true;
                _activeHatchet = false;
                _activePickaxe = false;
                break;
            case ("Item(3)"): // Hatchet
                _button.GetComponent<Image>().sprite = _buttonstate[1];
                _button.GetComponent<Button>().interactable = true;
                _activeBag = false;
                _activeHatchet = true;
                _activePickaxe = false;
                break;
            case ("Item(4)"): // Pickaxe
                _button.GetComponent<Image>().sprite = _buttonstate[1];
                _button.GetComponent<Button>().interactable = true;
                _activeBag = false;
                _activeHatchet = false;
                _activePickaxe = true;
                break;
            default:
                _button.GetComponent<Image>().sprite = _buttonstate[0];
                _button.GetComponent<Button>().interactable = false;
                _activeBag = false;
                _activeHatchet = false;
                _activePickaxe = false;
                break;
        }
    }

    public void rounds()
    {
        _sliderValue = GameObject.Find("Scrollbar").GetComponent<Scrollbar>().value;
        for (int i = 0; i < (int)(_sliderValue * 10); i++)
        {
            drawCard();
        }
    }



    // take a resource from the resource deck
    public void drawCard()
    {
        //every time u try to get a resource it takesawaye a littel extra time
        GameObject.Find("Health / timer").GetComponent<HealthAndTimerTEST>()._curentTime -= .05f;

        //if deck is empty, add the discard pile to the deck
        if (cards.Count == 0)
        {
            discardCard();
        }

        randomSelector = Random.Range(0, cards.Count);
        //gotCard.text = cards[randomSelector];

        //if a wood was drawn
        if (cards[randomSelector] == "wood")
        {
            var ins = Instantiate(_floatResource, GameObject.Find("Button (1)").transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            ins.GetComponent<itemDrop>()._sprite = _resources[5];
            _playerInv._WoodCount++;
            _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
            if (_activeHatchet)
            {
                _playerInv._WoodCount++;
                StartCoroutine(Bonus(5));
            }
        }

        //if a stone was drawn
        if (cards[randomSelector] == "stone")
        {
            var ins = Instantiate(_floatResource, GameObject.Find("Button (1)").transform.position,Quaternion.identity, GameObject.Find("Canvas").transform);
            ins.GetComponent<itemDrop>()._sprite = _resources[4];
            _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
            _playerInv._StoneCount++;
            if(_activePickaxe)
            {
                _playerInv._StoneCount++;
                StartCoroutine(Bonus(4));
            }
        }

        //if a fiber was drawn
        if (cards[randomSelector] == "fiber")
        {
            var ins = Instantiate(_floatResource, GameObject.Find("Button (1)").transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            ins.GetComponent<itemDrop>()._sprite = _resources[2];
            _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
            _playerInv._FiberCount++;
        }

        //if a hide was drawn
        if (cards[randomSelector] == "hide")
        {
            var ins = Instantiate(_floatResource, GameObject.Find("Button (1)").transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            ins.GetComponent<itemDrop>()._sprite = _resources[3];
            _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
            _playerInv._HideCount++;
        }

        //if a bone was drawn
        if (cards[randomSelector] == "bone")
        {
            var ins = Instantiate(_floatResource, GameObject.Find("Button (1)").transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            ins.GetComponent<itemDrop>()._sprite = _resources[1];
            _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
            _playerInv._BoneCount++;
        }

        //if a bone was drawn
        if (cards[randomSelector] == "berry")
        {
            var ins = Instantiate(_floatResource, GameObject.Find("Button (1)").transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            ins.GetComponent<itemDrop>()._sprite = _resources[0];
            _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
            _playerInv._berryCount++;
            if(_activeBag)
            {
                _playerInv._berryCount++;
                StartCoroutine(Bonus(0));
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
    }

    IEnumerator Bonus(int index)
    {
        yield return new WaitForSeconds(.2f);
        _soundLib.GetComponent<soundsLib>().audioPlay("CraftItem");
        var ins2 = Instantiate(_floatResource, GameObject.Find("Button (1)").transform.position, Quaternion.identity,GameObject.Find("Canvas").transform);
        ins2.GetComponent<itemDrop>()._sprite = _resources[index];

    }

    //take all cards from the discard pile and add them to the deck
    public void discardCard()
    {
        for (int i = 0; i < 5; i++)
        {
            cards.Add(disCards[0]);
            disCards.RemoveAt(0);
        }
    }

}
