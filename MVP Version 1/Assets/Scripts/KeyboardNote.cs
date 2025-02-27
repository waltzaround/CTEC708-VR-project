﻿using UnityEngine;
using System.Collections;

public class KeyboardNote : MonoBehaviour {

	public GameObject cnoteTrigger;
	public GameObject dnoteTrigger;
	public GameObject enoteTrigger;
	public GameObject fnoteTrigger;
	public GameObject gnoteTrigger;
	public GameObject anoteTrigger;
	public GameObject bnoteTrigger;
	public GameObject c2noteTrigger;
	private AudioSource cnote;
	private AudioSource dnote;
	private AudioSource enote;
	private AudioSource fnote;
	private AudioSource gnote;
	private AudioSource anote;
	private AudioSource bnote;
	private AudioSource c2note;
	public HandBehaviourV2 handNote;

	// Use this for initialization
	void Start () {
		cnote = cnoteTrigger.GetComponent<AudioSource> ();
		dnote = dnoteTrigger.GetComponent<AudioSource> ();
		enote = enoteTrigger.GetComponent<AudioSource> ();
		fnote = fnoteTrigger.GetComponent<AudioSource> ();
		gnote = gnoteTrigger.GetComponent<AudioSource> ();
		anote = anoteTrigger.GetComponent<AudioSource> ();
		bnote = bnoteTrigger.GetComponent<AudioSource> ();
		c2note = c2noteTrigger.GetComponent<AudioSource> ();
		HandBehaviourV2 handNote = GetComponent<HandBehaviourV2> ();
	}

	void OnTriggerEnter(Collider other) {
		//Debug.Log ("happening");
		if (other.gameObject.CompareTag("C")) {
			//Debug.Log ("true");
			cnote.Play();
			handNote.latestNote = "C";
		}
		if (other.gameObject.CompareTag("D")) {
			dnote.Play();
			handNote.latestNote = "D";
		}
		if (other.gameObject.CompareTag("E")) {
			enote.Play();
			handNote.latestNote = "E";
		}
		if (other.gameObject.CompareTag("F")) {
			fnote.Play();
			handNote.latestNote = "F";
		}
		if (other.gameObject.CompareTag("G")) {
			gnote.Play();
			handNote.latestNote = "G";
		}
		if (other.gameObject.CompareTag("A")) {
			anote.Play();
			handNote.latestNote = "A";
		}
		if (other.gameObject.CompareTag("B")) {
			bnote.Play();
			handNote.latestNote = "B";
		}
		if (other.gameObject.CompareTag("C2")) {
			c2note.Play();
			handNote.latestNote = "C";
		}
	}
	void OnTriggerExit(Collider other) {
		handNote.latestNote = " ";
	}
}
