// See https://aka.ms/new-console-template for more information
using MqttClientConsole;
Console.WriteLine("Hello, World!");

MqttClientService mqttClientService = new MqttClientService();
mqttClientService.MqttClientStart();

Console.ReadLine();

mqttClientService.Publish("Hello, Client1");

Console.ReadLine();