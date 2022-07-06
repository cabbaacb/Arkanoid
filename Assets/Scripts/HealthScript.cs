using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] private Text _textBox;
    [SerializeField] private PlayerController _player;
    // Start is called before the first frame update
    void Start()
    {
        _textBox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _textBox.text = ": " + _player.Health.ToString();

        if(_player.Health <= 0)
        {
            _textBox.text = "You're dead!\n(but still can play)";
        }
    }
}
