/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using ET;
using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    [ObjectSystem]
    public class FUI_NetLoading_AwakeSystem : AwakeSystem<FUI_NetLoading, GObject>
    {
        public override void Awake(FUI_NetLoading self, GObject go)
        {
            self.Awake(go);
        }
    }
        
    public sealed class FUI_NetLoading : FUI
    {	
        public const string UIPackageName = "Common";
        public const string UIResName = "NetLoading";
        
        /// <summary>
        /// {uiResName}的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GComponent self;
            
    public GMovieClip m_Anim;
    public const string URL = "ui://kqsmrpxlt4cw24";

    private static GObject CreateGObject()
    {
        return UIPackage.CreateObject(UIPackageName, UIResName);
    }
    
    private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
    {
        UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
    }
        
    public static FUI_NetLoading CreateInstance(Entity domain)
    {			
        return EntityFactory.Create<FUI_NetLoading, GObject>(domain, CreateGObject());
    }
        
    public static ETTask<FUI_NetLoading> CreateInstanceAsync(Entity domain)
    {
        ETTaskCompletionSource<FUI_NetLoading> tcs = new ETTaskCompletionSource<FUI_NetLoading>();

        CreateGObjectAsync((go) =>
        {
            tcs.SetResult(EntityFactory.Create<FUI_NetLoading, GObject>(domain, go));
        });

        return tcs.Task;
    }
        
    public static FUI_NetLoading Create(Entity domain,GObject go)
    {
        return EntityFactory.Create<FUI_NetLoading, GObject>(domain,go);
    }
        
    /// <summary>
    /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
    /// </summary>
    public static FUI_NetLoading GetFormPool(Entity domain,GObject go)
    {
        var fui = go.Get<FUI_NetLoading>();

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
        
        self = (GComponent)go;
        
        self.Add(this);
        
        var com = go.asCom;
            
        if(com != null)
        {	
            
    		m_Anim = (GMovieClip)com.GetChild("Anim");
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
            
		m_Anim = null;
	}
}
}