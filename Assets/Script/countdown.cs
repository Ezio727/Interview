using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
	public Text HourAndMinute;
	public Text Seconds;
	public float blinkRate;
	public float _countdown;
	public Text counter;
	public bool started;
	public InputField infield;
	public Button startBut;
	void Start()
	{
		InvokeRepeating("blinkTheText", 0f, blinkRate);
	}
	void Update()
	{
		System.DateTime time = System.DateTime.Now;
		HourAndMinute.text = time.ToString("hh mm");
		if (_countdown > 0 && started)
			_countdown -= Time.deltaTime;
		if (_countdown <= 0)
			started = false;
		counter.text = Mathf.RoundToInt(_countdown).ToString();
		if (started)
		{
			startBut.transform.GetChild(0).gameObject.SetActive(false);
			startBut.transform.GetChild(1).gameObject.SetActive(true);
		}
		else
		{
			startBut.transform.GetChild(0).gameObject.SetActive(true);
			startBut.transform.GetChild(1).gameObject.SetActive(false);
		}
	}
	public void OnStart()
    {
		if (infield.text != "")
		{
			if (int.Parse(infield.text) < 0)
				return;
			if (!started)
				_countdown = int.Parse(infield.text);
			started = !started;
		}
	}
	void blinkTheText()
	{
		if (Seconds.enabled)
			Seconds.enabled = false;
		else
			Seconds.enabled = true;
	}
}
