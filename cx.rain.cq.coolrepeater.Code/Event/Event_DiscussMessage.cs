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
    public class Event_DiscussMessage : IDiscussMessage
    {
        public void DiscussMessage(object sender, CQDiscussMessageEventArgs e)
        {
            if (CoolRepeater.DisabledGroups.Contains(e.FromDiscuss.Id))
            {
                return;
            }
            if (!CoolRepeater.EnabledGroups.Contains(e.FromDiscuss.Id))
            {
                return;
            }

            var noContentMessage = new QQMessage(e.CQApi, -1, string.Empty);
            var groupLastMessages = CoolRepeater.GroupLastMessages;
            if (!groupLastMessages.ContainsKey($"D{e.FromDiscuss.Id}"))
            {
                groupLastMessages.Add($"D{e.FromDiscuss.Id}", new Tuple<long, QQMessage>(e.FromQQ.Id, noContentMessage));
            }

            var groupMessageSenders = CoolRepeater.GropuMessageSenders;
            if (!groupMessageSenders.ContainsKey($"D{e.FromDiscuss.Id}"))
            {
                groupMessageSenders.Add($"D{e.FromDiscuss.Id}", new HashSet<long>());
            }

            var groupRepeatedMessage = CoolRepeater.GroupRepeatedMessages;
            if (!groupRepeatedMessage.ContainsKey($"D{e.FromDiscuss.Id}"))
            {
                groupRepeatedMessage.Add($"D{e.FromDiscuss.Id}", noContentMessage);
            }

            var lastMessage = groupLastMessages[$"D{e.FromDiscuss.Id}"];
            var senders = groupMessageSenders[$"D{e.FromDiscuss.Id}"];
            var lastRepeated = groupRepeatedMessage[$"D{e.FromDiscuss.Id}"];

            if (e.Message.Text != lastMessage.Item2.Text)
            {
                groupLastMessages[$"D{e.FromDiscuss.Id}"] = new Tuple<long, QQMessage>(e.FromQQ.Id, e.Message);
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
                    if (new Random().Next(2) == 0)
                    {
                        senders.Clear();
                        return;
                    }
                }
                else
                {
                    if ((decimal) new Random().NextDouble() >= CoolRepeater.RepeatProbability)
                    {
                        senders.Clear();
                        return;
                    }
                }
                e.CQApi.SendDiscussMessage(e.FromDiscuss, repeatString);
                groupRepeatedMessage[$"D{e.FromDiscuss.Id}"] = e.Message;
                senders.Clear();
            }
        }
    }
}
