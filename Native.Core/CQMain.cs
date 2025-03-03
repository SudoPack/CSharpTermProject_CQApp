﻿using cc.wnapp.whuHelper.Code;
using cc.wnapp.whuHelper.UI;
using Native.Sdk.Cqp.Interface;
using Unity;
using static cc.wnapp.whuHelper.Code.IF;

namespace Native.Core
{
	/// <summary>
	/// 酷Q应用主入口类
	/// </summary>
	public class CQMain
	{
		/// <summary>
		/// 在应用被加载时将调用此方法进行事件注册, 请在此方法里向 <see cref="IUnityContainer"/> 容器中注册需要使用的事件
		/// </summary>
		/// <param name="container">用于注册的 IOC 容器 </param>
		public static void Register (IUnityContainer unityContainer)
		{
			unityContainer.RegisterType<IMenuCall, OpenWindowA>("设置");
			unityContainer.RegisterType<IMenuCall, MenuInitEas>("重置教务系统数据库");
			unityContainer.RegisterType<IMenuCall, MenuInitSch>("重置日程数据库");
			unityContainer.RegisterType<IMenuCall, MenuInitGit>("重置Git提醒数据库");
			unityContainer.RegisterType<IMenuCall, MenuInitAtt>("重置关注数据库");
			unityContainer.RegisterType<IGroupMessage, event_Message>("群消息处理");
			unityContainer.RegisterType<IPrivateMessage, event_Message>("私聊消息处理");
			unityContainer.RegisterType<ICQStartup, event_CQStartup>("酷Q启动事件");
			unityContainer.RegisterType<IAppEnable, event_AppStartup>("应用已被启用");
		}
	}
}
