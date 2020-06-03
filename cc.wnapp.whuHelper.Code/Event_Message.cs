﻿using Native.Sdk.Cqp;
using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using Native.Sdk.Cqp.Model;
using RestSharp;
using System;
using System.IO;
using System.Net.Configuration;
using System.Threading;

namespace cc.wnapp.whuHelper.Code
{
    public class event_Message : IGroupMessage, IPrivateMessage
    {
        /// <summary>
        /// 群消息处理
        /// </summary>
        public void GroupMessage(object sender, CQGroupMessageEventArgs e)
        {
            /*
           CQ.Api.SendGroupMessage(e.FromGroup, "外部Call Api示例");
           CQ.Log.Debug("测试", "外部Call Log示例");
           // 获取 At 某人对象
           CQCode cqat = e.FromQQ.CQCode_At();
           // 往来源群发送一条群消息, 下列对象会合并成一个字符串发送
           e.FromGroup.SendGroupMessage(cqat, " 您发送了一条消息: ", e.Message);
           // 设置该属性, 表示阻塞本条消息, 该属性会在方法结束后传递给酷Q
           e.Handler = true;
            */
            QQ BotQQ = CQ.Api.GetLoginQQ();
            string msg = e.Message;
            string fromqq = e.FromQQ;
            msgProcess.GroupAttentionHandler(fromqq, msg, Convert.ToString(BotQQ.Id));

        }

        /// <summary>
        /// 私聊消息处理
        /// </summary>
        public void PrivateMessage(object sender, CQPrivateMessageEventArgs e)
        {
            QQ BotQQ = CQ.Api.GetLoginQQ();
            string msg = e.Message;
            string fromqq = e.FromQQ;
            if (msg.Contains("绑定教务系统"))
            {
                msgProcess.bdjw(fromqq, msg, Convert.ToString(BotQQ.Id));
            }
            if (msg.Contains("关注") || msg.Contains("订阅")) 
            {
                msgProcess.PrivateAttentionHandler(fromqq, msg, Convert.ToString(BotQQ.Id));
            }
        }

    }

}
