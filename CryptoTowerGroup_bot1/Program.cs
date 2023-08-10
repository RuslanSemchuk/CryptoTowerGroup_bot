using Telegram.Bot;

var botClient = new TelegramBotClient("{6439952428:AAHgcInkAPuRBxwGpCO7rEGxsc0kOcv_xrk}");

var me = await botClient.GetMeAsync();
Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");