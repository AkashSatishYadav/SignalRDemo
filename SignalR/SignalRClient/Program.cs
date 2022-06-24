// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.SignalR.Client;

// Build the connection
HubConnection connection = new HubConnectionBuilder()
    .WithUrl("https://localhost:7131/ChatHub")
    .WithAutomaticReconnect()
    .Build();

// Add Event listner
connection.On<string, string>("Publish Message", (user, message) =>
{
    Console.WriteLine($"{user} : {message}");
});

// start the connection
connection.StartAsync();

// send the message
connection.SendAsync("SendData", "Client1", "Hi");

Console.ReadKey();
