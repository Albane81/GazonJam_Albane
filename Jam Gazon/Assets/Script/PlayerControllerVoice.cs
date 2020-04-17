using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class PlayerControllerVoice : MonoBehaviour
{
    private PlayerMove player;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    // Start is called before the first frame update
    void Start()
    {
        actions.Add("droite", Droite);
        actions.Add("droi", Droite);
        actions.Add("gauche", Gauche);
        actions.Add("go", Gauche);
        actions.Add("haut", Haut);
        actions.Add("bas", Bas);
        actions.Add("tir", Tir);
        actions.Add("ti", Tir);

        player = GetComponent<PlayerMove>();
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();

    }

    private void Droite()
    {
        //transform.Translate(1, 0, 0);
        player.Direction = Vector2.right;

    }
    private void Gauche()
    {
        player.Direction = Vector2.left;
    }
    private void Haut()
    {
        player.Direction = Vector2.up;
    }
    private void Bas()
    {
        player.Direction = Vector2.down;
    }
    private void Tir()
    {
        
        player.Shot();
        
    }
}
