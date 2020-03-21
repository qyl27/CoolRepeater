using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using Native.Sdk.Cqp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.coolrepeater.Code.Event
{
    public class Event_GroupMessage : IGroupMessage
    {
        public void GroupMessage(object sender, CQGroupMessageEventArgs e)
        {
            if (CoolRepeater.DisabledGroups.Contains(e.FromGroup.Id))
            {
                return;
            }
            if (!CoolRepeater.EnabledGroups.Contains(e.FromGroup.Id))
            {
                return;
            }

            if (CoolRepeater.IgnoreAnonymous && e.IsFromAnonymous)
            {
                return;
            }
            var noContentMessage = new QQMessage(e.CQApi, -1, string.Empty);
            var groupLastMessages = CoolRepeater.GroupLastMessages;
            if (!groupLastMessages.ContainsKey($"G{e.FromGroup.Id}"))
            {
                groupLastMessages.Add($"G{e.FromGroup.Id}", new Tuple<long, QQMessage>(e.FromQQ.Id, noContentMessage));
            }

            var groupMessageSenders = CoolRepeater.GropuMessageSenders;
            if (!groupMessageSenders.ContainsKey($"G{e.FromGroup.Id}"))
            {
                groupMessageSenders.Add($"G{e.FromGroup.Id}", new HashSet<long>());
            }

            var groupRepeatedMessage = CoolRepeater.GroupRepeatedMessages;
            if (!groupRepeatedMessage.ContainsKey($"G{e.FromGroup.Id}"))
            {
                groupRepeatedMessage.Add($"G{e.FromGroup.Id}", noContentMessage);
            }

            var lastMessage = groupLastMessages[$"G{e.FromGroup.Id}"];
            var senders = groupMessageSenders[$"G{e.FromGroup.Id}"];
            var lastRepeated = groupRepeatedMessage[$"G{e.FromGroup.Id}"];

            if (e.Message.Text != lastMessage.Item2.Text)
            {
                groupLastMessages[$"G{e.FromGroup.Id}"] = new Tuple<long, QQMessage>(e.FromQQ.Id, e.Message);
                senders.Clear();
                return;
            }
            else
            {
                senders.Add(e.FromQQ.Id);
            }

            if (lastRepeated.Text == e.Message.Text)
            {
                senders.Clear();
                return;
            }

            if (senders.Count >= (CoolRepeater.RepeatThreshold - 1))
            {
                var repeatString = e.Message.ToSendString();
                foreach (var s in CoolRepeater.BlockWords)
                {
                    if (repeatString.Contains(s))
                    {
                        senders.Clear();
                        return;
                    }
                }
                if (CoolRepeater.RandomRepeatProbability)
                {
                    var random = new Random();
                    if ((decimal) random.NextDouble() <= (decimal) random.NextDouble())
                    {
                        senders.Clear();
                        return;
                    }
                }
                else
                {
                    if ((decimal)new Random().NextDouble() <= CoolRepeater.RepeatProbability)
                    {
                        senders.Clear();
                        return;
                    }
                }
                e.CQApi.SendGroupMessage(e.FromGroup, repeatString);
                groupRepeatedMessage[$"G{e.FromGroup.Id}"] = e.Message;
                senders.Clear();
            }
        }
    }
}

