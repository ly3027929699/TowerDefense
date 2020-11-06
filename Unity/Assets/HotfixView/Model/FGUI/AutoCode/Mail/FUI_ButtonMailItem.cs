/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using ET;
using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    [ObjectSystem]
    public class FUI_ButtonMailItem_AwakeSystem : AwakeSystem<FUI_ButtonMailItem, GObject>
    {
        public override void Awake(FUI_ButtonMailItem self, GObject go)
        {
            self.Awake(go);
        }
    }
        
    public sealed class FUI_ButtonMailItem : FUI
    {	
        public const string UIPackageName = "Mail";
        public const string UIResName = "ButtonMailItem";
        
        /// <summary>
        /// {uiResName}的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GButton self;
            
    public Controller m_Read;
    public GImage m_bg;
    public GTextField m_txtTitle;
    public GTextField m_txtTime;
    public GTextField m_txtSenderName;
    public const string URL = "ui://ba6u515vralqb";

    private static GObject CreateGObject()
    {
        return UIPackage.CreateObject(UIPackageName, UIResName);
    }
    
    private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
    {
        UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
    }
        
    public static FUI_ButtonMailItem CreateInstance(Entity domain)
    {			
        return EntityFactory.Create<FUI_ButtonMailItem, GObject>(domain, CreateGObject());
    }
        
    public static ETTask<FUI_ButtonMailItem> CreateInstanceAsync(Entity domain)
    {
        ETTaskCompletionSource<FUI_ButtonMailItem> tcs = new ETTaskCompletionSource<FUI_ButtonMailItem>();

        CreateGObjectAsync((go) =>
        {
            tcs.SetResult(EntityFactory.Create<FUI_ButtonMailItem, GObject>(domain, go));
        });

        return tcs.Task;
    }
        
    public static FUI_ButtonMailItem Create(Entity domain,GObject go)
    {
        return EntityFactory.Create<FUI_ButtonMailItem, GObject>(domain,go);
    }
        
    /// <summary>
    /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
    /// </summary>
    public static FUI_ButtonMailItem GetFormPool(Entity domain,GObject go)
    {
        var fui = go.Get<FUI_ButtonMailItem>();

        if(fui == null)
        {
            fui = Create(domain,go);
        }

        fui.isFromFGUIPool = true;

        return fui;
    }
        
    public void Awake(GObject go)
    {
        if(go == null)
        {
            return;
        }
        
        GObject = go;	
        
        if (string.IsNullOrWhiteSpace(Name))
        {
            Name = Id.ToString();
        }
        
        self = (GButton)go;
        
        self.Add(this);
        
        var com = go.asCom;
            
        if(com != null)
        {	
            
    		m_Read = com.GetController("Read");
    		m_bg = (GImage)com.GetChild("bg");
    		m_txtTitle = (GTextField)com.GetChild("txtTitle");
    		m_txtTime = (GTextField)com.GetChild("txtTime");
    		m_txtSenderName = (GTextField)com.GetChild("txtSenderName");
    	}
}
public override void Dispose()
    {
        if(IsDisposed)
        {
            return;
        }
        
        base.Dispose();
        
        self.Remove();
        self = null;
            
		m_Read = null;
		m_bg = null;
		m_txtTitle = null;
		m_txtTime = null;
		m_txtSenderName = null;
	}
}
}