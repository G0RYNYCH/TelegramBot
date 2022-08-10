var botClient = new TelegramBotClient("5509847805:AAENAqMzNRfFoG30Yo3iwVbnUTDyXyB4xrA");

var me = await botClient.GetMeAsync();
Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");