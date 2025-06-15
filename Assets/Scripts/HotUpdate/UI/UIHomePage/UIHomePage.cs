using System.Collections;
using System.Collections.Generic;
using DPGame;
using UnityEngine;
using F8Framework.Core;
using F8Framework.Launcher;

public class UIHomePage : BaseView
{
    // Awake
    protected override void OnAwake()
    {
        Button_Start_Button.onClick.AddListener(Start);
    }
    
    // 参数传入，每次打开UI都会执行
    protected override void OnAdded(int uiId, object[] args = null)
    {
      
    }
    
    // Start
    protected override void OnStart()
    {
       
    }
    
    protected override void OnViewTweenInit()
    {
        //transform.localScale = Vector3.one * 0.7f;
    }
    
    // 自定义打开界面动画
    protected override void OnPlayViewTween()
    {
        //transform.ScaleTween(Vector3.one, 0.1f).SetEase(Ease.Linear).SetOnComplete(OnViewOpen);
    }
    
    // 打开界面动画完成后
    protected override void OnViewOpen()
    {
        
    }
    
    // 删除之前，每次UI关闭前调用
    protected override void OnBeforeRemove()
    {
        
    }
    
    // 删除，UI关闭后调用
    protected override void OnRemoved()
    {
       
    }

    void Start()
    {
        LogF8.Log("测试游戏开始事件", this);
        FF8.Message.DispatchEvent(DPMessageEvent.GameStart);
    }
    
    // 自动获取组件（自动生成，不能删除）
    [SerializeField] private UnityEngine.UI.Image Image_Background_Image;
    [SerializeField] private UnityEngine.UI.Button Button_Start_Button;
    [SerializeField] private UnityEngine.UI.Button Button_Option_Button;
    [SerializeField] private UnityEngine.UI.Button Button_Other_Button;
    [SerializeField] private UnityEngine.UI.Button Button_News_Button;
    [SerializeField] private UnityEngine.UI.Button Button_Quit_Button;
    [SerializeField] private TMPro.TMP_Text TextTMP_Start_TextTMP;
    [SerializeField] private TMPro.TMP_Text TextTMP_Option_TextTMP;
    [SerializeField] private TMPro.TMP_Text TextTMP_Other_TextTMP;
    [SerializeField] private TMPro.TMP_Text TextTMP_News_TextTMP;
    [SerializeField] private TMPro.TMP_Text TextTMP_Quit_TextTMP;

#if UNITY_EDITOR
    protected override void SetComponents()
    {
        Image_Background_Image = transform.Find("Image_Background").GetComponent<UnityEngine.UI.Image>();
        Button_Start_Button = transform.Find("Buttons/Button_Start").GetComponent<UnityEngine.UI.Button>();
        Button_Option_Button = transform.Find("Buttons/Button_Option").GetComponent<UnityEngine.UI.Button>();
        Button_Other_Button = transform.Find("Buttons/Button_Other").GetComponent<UnityEngine.UI.Button>();
        Button_News_Button = transform.Find("Buttons/Button_News").GetComponent<UnityEngine.UI.Button>();
        Button_Quit_Button = transform.Find("Buttons/Button_Quit").GetComponent<UnityEngine.UI.Button>();
        TextTMP_Start_TextTMP = transform.Find("Buttons/Button_Start/Text (TMP)_Start").GetComponent<TMPro.TMP_Text>();
        TextTMP_Option_TextTMP = transform.Find("Buttons/Button_Option/Text (TMP)_Option").GetComponent<TMPro.TMP_Text>();
        TextTMP_Other_TextTMP = transform.Find("Buttons/Button_Other/Text (TMP)_Other").GetComponent<TMPro.TMP_Text>();
        TextTMP_News_TextTMP = transform.Find("Buttons/Button_News/Text (TMP)_News").GetComponent<TMPro.TMP_Text>();
        TextTMP_Quit_TextTMP = transform.Find("Buttons/Button_Quit/Text (TMP)_Quit").GetComponent<TMPro.TMP_Text>();
    }
#endif
    // 自动获取组件（自动生成，不能删除）
}