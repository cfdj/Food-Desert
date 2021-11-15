using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }

    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            if (this != _instance)
                Destroy(this.gameObject);
        }

        if (HealthPanel != null)
        {
            _healthSlider = HealthPanel.Find("HealthSlider").GetComponent<Slider>();

            _healthText = HealthPanel.Find("HealthText").GetComponent<Text>();

            _maxHunger = _healthSlider.maxValue;
        }

    }

    public void Start()
    {
        _hungerSeconds = 0;

        // Invoke the CountSeconds every second to count the passed seconds
        InvokeRepeating("CountSeconds", 1.0f, 1.0f);
    }

    public void Update()
    {
        if (_healthSlider != null && _healthText != null)
        {
            _healthSlider.value = (float)_hungerSeconds;

            _healthText.text = String.Format("Hunger: {0} | {1}", _hungerSeconds, _maxHunger);

            // TODO: If _hungerSeconds >= maxHunger --> Death ...
        }
    }

    void CountSeconds()
    {
        _hungerSeconds++;
    }

    // Slider of the health panel
    private UnityEngine.UI.Slider _healthSlider;

    // Text to display the health / hunger
    private UnityEngine.UI.Text _healthText;

    // Seconds passed...
    private float _hungerSeconds = 0.0f;

    // ... til the hunger reaches maximum -> death
    private float _maxHunger = 0.0f;

    // Health / Hunger panel
    public RectTransform HealthPanel = null;

}
