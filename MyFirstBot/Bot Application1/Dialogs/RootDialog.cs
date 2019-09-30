using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Bot_Application1.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;

            // return our reply to the user
           
            switch (activity.Text)
            {
                case "Salem": case "salem":
                    await context.PostAsync($"wa 3alaykom salem");
                    break;
                case "cv ?": case "Cv":  case "cv":
                    await context.PostAsync($"el Hamdouli allah w nta ?");
                    break;
                case "kech jdid":
                    await context.PostAsync($"wlh walooo");
                    break;
                case "hmd":
                case "hmdlh":
                case "el hamdouli allah":
                    await context.PostAsync($"{activity.Text}");
                    break;
                   
                case "wech tgol l team open mind ?":
                    await context.PostAsync($"Saha ftorkom !");
                    break;
                case "sahit":
                    await context.PostAsync($"hafdeh ;-)");
                    break;
                default:
                    {
                        await context.PostAsync($"You sent {activity.Text} which was {length} characters");
                        break;
                    }
            }
           
            context.Wait(MessageReceivedAsync);
        }
    }
}