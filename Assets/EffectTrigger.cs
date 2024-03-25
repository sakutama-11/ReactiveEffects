using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;

public class EffectTrigger : MonoBehaviour
{
    [SerializeField] public UnityEvent<float> TriggerSnare;
    [SerializeField] public UnityEvent<float> TriggerKick;
    [SerializeField] public UnityEvent<float> Trigger1;
    [SerializeField] public UnityEvent<float> Trigger2;
    [SerializeField] public UnityEvent<float> Trigger3;
    [SerializeField] public UnityEvent<float> Trigger4;
    [SerializeField] public UnityEvent<float> Trigger5;
    
    [SerializeField] public float Intensity = 1f;
    
    void Update()
    {
 #if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.F))
        {
            TriggerSnare.Invoke(Intensity);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TriggerKick.Invoke(Intensity);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Trigger1.Invoke(Intensity);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Trigger2.Invoke(Intensity);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Trigger3.Invoke(Intensity);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Trigger4.Invoke(Intensity);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Trigger5.Invoke(Intensity);
        }   
#endif
    }
}


// 各Triggerを実行できるボタンをエディタ拡張で表示

[CustomEditor(typeof(EffectTrigger))]//拡張するクラスを指定
public class EffectTriggerEditor : Editor {

    /// <summary>
    /// InspectorのGUIを更新
    /// </summary>
    public override void OnInspectorGUI(){
        //元のInspector部分を表示
        base.OnInspectorGUI();

        //targetを変換して対象を取得
        EffectTrigger effectTrigger = target as EffectTrigger;
        
        if(effectTrigger == null){
            return;
        }

        //ボタンを表示
        if(GUILayout.Button("Trigger Snare")){
            effectTrigger.TriggerSnare.Invoke(effectTrigger.Intensity);
        }
        if(GUILayout.Button("Trigger Kick")){
            effectTrigger.TriggerKick.Invoke(effectTrigger.Intensity);
        }
        if(GUILayout.Button("Trigger 1")){
            effectTrigger.Trigger1.Invoke(effectTrigger.Intensity);
        }
        if(GUILayout.Button("Trigger 2")){
            effectTrigger.Trigger2.Invoke(effectTrigger.Intensity);
        }
        if(GUILayout.Button("Trigger 3")){
            effectTrigger.Trigger3.Invoke(effectTrigger.Intensity);
        }
        if(GUILayout.Button("Trigger 4")){
            effectTrigger.Trigger4.Invoke(effectTrigger.Intensity);
        }
        if(GUILayout.Button("Trigger 5")){
            effectTrigger.Trigger5.Invoke(effectTrigger.Intensity);
        }
    }

}  